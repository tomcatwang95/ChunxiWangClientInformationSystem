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
    public class EmployeeRepository : EfRepository<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(ClientSystemDBContext dbContext) : base(dbContext)
        {

        }
        public async Task<Employees> GetEmployeeById(int id)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
            return employee;
        }

        public async Task<Employees> GetEmployeeByName(string name)
        {
            var employee = await _dbContext.Employees.FirstOrDefaultAsync(e => e.Name == name);
            return employee;
        }
        public async Task<List<Employees>> GetAllEmployees()
        {
            var employees = await _dbContext.Employees.ToListAsync();

            return employees;
        }
    }
}
