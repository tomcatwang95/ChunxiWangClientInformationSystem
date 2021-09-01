using ApplicationCore.Entities;
using ApplicationCore.Exceptions;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class InteractionService : IInteractionService
    {
        private readonly IInteractionRepository _interactionRepository;
        public InteractionService(IInteractionRepository interactionRepository)
        {
            _interactionRepository = interactionRepository;
        }
        public async Task<InteractionDetailsResponseModel> GetInteractionDetails(int id)
        {
            var interaction = await _interactionRepository.GetInteractionById(id);
            if (interaction == null)
            {
                return null;
            }
            var InteractionDetailModel = new InteractionDetailsResponseModel
            {
                Id = interaction.Id,
                EmpId = (int)interaction.EmpId,
                ClientId = (int)interaction.ClientId,
                IntType= (char)interaction.IntType,
                IntDate=(DateTime)interaction.IntDate,
                Remarks=interaction.Remarks
            };
            return InteractionDetailModel;
        }
        public async Task<InteractionDetailsResponseModel> CreateInteraction(InteractionCreatRequestModel interaction)
        {
            var newInteraction = await _interactionRepository.AddAsync(new Interaction
            {
                ClientId=interaction.ClientId,
                EmpId=interaction.EmpId,
                IntType=interaction.IntType,
                IntDate=interaction.IntDate,
                Remarks=interaction.Remarks
                
            });
            return new InteractionDetailsResponseModel
            {
                EmpId = (int)newInteraction.EmpId,
                ClientId = (int)newInteraction.ClientId,
                IntType = (char)newInteraction.IntType,
                IntDate = (DateTime)newInteraction.IntDate,
                Remarks = newInteraction.Remarks
            };
        }
        public async Task<InteractionDetailsResponseModel> UpdateInteraction(InteractionUpdateRequestModel interaction)
        {
            var dbInteraction = await _interactionRepository.GetByIdAsync(interaction.Id);
            if (dbInteraction == null)
            {
                throw new ConflictException("No Employee exists");
            }
            dbInteraction.Id = interaction.Id;
            dbInteraction.ClientId = interaction.ClientId;
            dbInteraction.EmpId = interaction.EmpId;
            dbInteraction.IntType = interaction.IntType;
            dbInteraction.IntDate = interaction.IntDate;
            dbInteraction.Remarks = interaction.Remarks;

            var updateEmployee = await _interactionRepository.UpdateAsync(dbInteraction);

            return await GetInteractionDetails(updateEmployee.Id);
        }
        public async Task<InteractionDetailsResponseModel> DeleteInteraction(int id)
        {
            var exist = await _interactionRepository.GetExistsAsync(i => i.Id == id);
            if (!exist)
            {
                throw new Exception("interaction does not exist");
            }
            var interaction = new Interaction
            {
                Id = id
            };
            var createdinteraction = await _interactionRepository.DeleteAsync(interaction);
            var interactionResponse = new InteractionDetailsResponseModel
            {
                Id = createdinteraction.Id,
                EmpId = (int)createdinteraction.EmpId,
                ClientId = (int)createdinteraction.ClientId,
                IntType = (char)createdinteraction.IntType,
                IntDate = (DateTime)createdinteraction.IntDate,
                Remarks = createdinteraction.Remarks
            };
            return interactionResponse;
        }
    }
}
