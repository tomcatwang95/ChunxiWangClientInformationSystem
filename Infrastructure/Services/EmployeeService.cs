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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<EmployeeLoginResponseModel> Login(LoginRequestModel model)
        {
            var dbUser = await _employeeRepository.GetEmployeeByName(model.Name);
            if (dbUser == null)
            {
                return null;
            }

            var Password = model.Password;

            if (Password == dbUser.Password)
            {
                // success 
                var EmployeeLoginResponseModel = new EmployeeLoginResponseModel
                {
                     Name = dbUser.Name,
                     Designation = dbUser.Designation
                };

                return EmployeeLoginResponseModel;
            }
            return null;
        }
        public async Task<EmployeeDetailResponseModel> GetEmployeeDetails(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            if (employee==null)
            {
                return null;
            }
            var EmployeeDetailModel = new EmployeeDetailResponseModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Designation = employee.Designation
            };
            return EmployeeDetailModel;

        }
        public async Task<EmployeeDetailResponseModel> CreateEmployee(EmployeeCreateRequestModel model)
        {
            var newEmployee = await _employeeRepository.AddAsync(new Employees
            {
                Name=model.Name,
                Password=model.Password,
                Designation=model.Designation
            });
            return new EmployeeDetailResponseModel
            {
                Name = newEmployee.Name,
                Designation = newEmployee.Designation
            };
        }
        public async Task<EmployeeDetailResponseModel> UpdateEmployee(EmployeeUpdateRequestModel employee)
        {
            var dbEmployee = await _employeeRepository.GetEmployeeById(employee.Id);
            if (dbEmployee == null)
            {
                throw new ConflictException("No Employee exists");
            }
            dbEmployee.Id = employee.Id;
            dbEmployee.Name = employee.Name;
            dbEmployee.Password = employee.Password;
            dbEmployee.Designation = employee.Designation;

            var updateEmployee = await _employeeRepository.UpdateAsync(dbEmployee);

            return await GetEmployeeDetails(updateEmployee.Id);
        }
        public async Task<EmployeeDetailResponseModel> DeleteEmployee(int id)
        {
            var exist = await _employeeRepository.GetExistsAsync(e => e.Id == id);
            if (!exist)
            {
                throw new Exception("Employee does not exist");
            }
            var employee = new Employees
            {
                Id = id
            };
            var createdEmployee = await _employeeRepository.DeleteAsync(employee);
            var employeeResponse = new EmployeeDetailResponseModel
            {
                Id = createdEmployee.Id,
                Name = createdEmployee.Name,
                Designation = createdEmployee.Designation
            };
            return employeeResponse;
        }
    }
}
