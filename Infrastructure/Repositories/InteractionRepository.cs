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
    public class InteractionRepository : EfRepository<Interaction>, IInteractionRepository
    {
        public InteractionRepository(ClientSystemDBContext dbContext) : base(dbContext)
        {

        }
        public async Task<Interaction> GetInteractionById(int id)
        {
            var interaction = await _dbContext.Interactions.FirstOrDefaultAsync(i => i.Id == id);
            return interaction;
        }
        public async Task<Interaction> GetInteractionByCombination(int empid, int clientid)
        {
            var interaction = await _dbContext.Interactions.FirstOrDefaultAsync(i => i.EmpId == empid && i.ClientId==clientid);
            return interaction;
        }
        public async Task<IEnumerable<Interaction>> GetAllInteraction()
        {
            var interactions = await _dbContext.Interactions.ToListAsync();

            return interactions;
        }
    }
}
