using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IInteractionRepository:IAsyncRepository<Interaction>
    {
        Task<Interaction> GetInteractionById(int id);
        Task<Interaction> GetInteractionByCombination(int empid, int clientid);
        Task<IEnumerable<Interaction>> GetAllInteraction();
    }
}
