using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApplicationCore.ServiceInterfaces
{
    public interface IInteractionService
    {
        Task<InteractionDetailsResponseModel> GetInteractionDetails(int id);
        Task<InteractionDetailsResponseModel> CreateInteraction(InteractionCreatRequestModel employee);
        Task<InteractionDetailsResponseModel> UpdateInteraction(InteractionUpdateRequestModel employee);
        Task<InteractionDetailsResponseModel> DeleteInteraction(int id);
    }
}
