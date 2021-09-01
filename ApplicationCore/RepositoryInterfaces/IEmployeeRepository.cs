using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IEmployeeRepository: IAsyncRepository<Employees>
    {
        Task<Employees> GetEmployeeByName(string name);
        Task<Employees> GetEmployeeById(int id);
        Task<List<Employees>> GetAllEmployees();
    }
}
