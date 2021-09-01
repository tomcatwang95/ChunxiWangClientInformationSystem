using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeLoginResponseModel> Login(LoginRequestModel model);
        Task<EmployeeDetailResponseModel> GetEmployeeDetails(int userId);
        Task<EmployeeDetailResponseModel> CreateEmployee(EmployeeCreateRequestModel employee);
        Task<EmployeeDetailResponseModel> UpdateEmployee(EmployeeUpdateRequestModel employee);
        Task<EmployeeDetailResponseModel> DeleteEmployee(int id);
    }
}
