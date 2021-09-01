using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository : EfRepository<Clients>, IClientRepository
    {
        public ClientRepository(ClientSystemDBContext dbContext) : base(dbContext)
        {

        }
        public async Task<Clients> GetClientById(int id)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Id == id);
            return client;
        }
        public async Task<Clients> GetClientByName(string name)
        {
            var client = await _dbContext.Clients.FirstOrDefaultAsync(c => c.Name == name);
            return client;
        }
        public async Task<IEnumerable<Clients>> GetAllClients()
        {
            var clients = await _dbContext.Clients.ToListAsync();

            return clients;
        }
    }
}
