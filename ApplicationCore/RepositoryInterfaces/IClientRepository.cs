using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IClientRepository:IAsyncRepository<Clients>
    {
        Task<Clients> GetClientById(int id);
        Task<Clients> GetClientByName(string name);
        Task<IEnumerable<Clients>> GetAllClients();
    }
}
