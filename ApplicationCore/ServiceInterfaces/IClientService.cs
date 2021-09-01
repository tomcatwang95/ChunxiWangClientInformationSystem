using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IClientService
    {
        Task<ClientDetailResponseModel> GetClientDetail(int id);
        Task<ClientDetailResponseModel> CreateClient(ClientCreateRequestModel client);
        Task<ClientDetailResponseModel> UpdateClient(ClientUpdateRequestModel client);
        Task<ClientDetailResponseModel> DeleteClient(int id);

    }
}
