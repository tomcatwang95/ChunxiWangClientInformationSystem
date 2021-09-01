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
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task<ClientDetailResponseModel> GetClientDetail(int id)
        {
            var client = await _clientRepository.GetClientById(id);
            if (client==null)
            {
                return null;
            }
            var ClientDetailModel = new ClientDetailResponseModel
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email,
                Phones=client.Phones,
                Address=client.Address,
                AddedOn=client.AddedOn
            };
            return ClientDetailModel;
        }
        public async Task<ClientDetailResponseModel> CreateClient(ClientCreateRequestModel model)
        {
            var newEmployee = await _clientRepository.AddAsync(new Clients
            {
                Name = model.Name,
                Email = model.Email,
                Phones = model.Phones,
                Address=model.Address,
                AddedOn=model.AddedOn
            });
            return new ClientDetailResponseModel
            {
                Name = newEmployee.Name,
                Email = newEmployee.Email,
                Phones = newEmployee.Phones,
                Address = newEmployee.Address,
                AddedOn = newEmployee.AddedOn
            };
        }
        public async Task<ClientDetailResponseModel> UpdateClient(ClientUpdateRequestModel client)
        {
            var dbClient = await _clientRepository.GetClientById(client.Id);
            if (dbClient == null)
            {
                throw new ConflictException("No Employee exists");
            }
            dbClient.Id = client.Id;
            dbClient.Name = client.Name;
            dbClient.Email = client.Email;
            dbClient.Phones = client.Phones;
            dbClient.Address = client.Address;
            dbClient.AddedOn = client.AddedOn;

            var updateEmployee = await _clientRepository.UpdateAsync(dbClient);

            return await GetClientDetail(updateEmployee.Id);
        }
        public async Task<ClientDetailResponseModel> DeleteClient(int id)
        {
            var exist = await _clientRepository.GetExistsAsync(c => c.Id == id);
            if (!exist)
            {
                throw new Exception("Client does not exist");
            }
            var client = new Clients
            {
                Id = id
            };
            var createdClient = await _clientRepository.DeleteAsync(client);
            var clientResponse = new ClientDetailResponseModel
            {
                Id = createdClient.Id,
                Name = createdClient.Name,
                Email = createdClient.Email,
                Phones = createdClient.Phones,
                Address= createdClient.Address,
                AddedOn=createdClient.AddedOn
            };
            return clientResponse;
        }

    }
}
