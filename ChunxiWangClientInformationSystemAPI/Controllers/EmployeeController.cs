using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ApplicationCore.ServiceInterfaces;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;

namespace ChunxiWangClientInformationSystemAPI.Controllers
{
        [Route("api/[controller]")]
        
        public class EmployeeController : ControllerBase
        {
            private readonly IEmployeeService _employeeService;
            private readonly IEmployeeRepository _employeeRepository;
            public EmployeeController(IEmployeeService employeeService, IEmployeeRepository employeeRepository)
            {
                _employeeService = employeeService;
                _employeeRepository = employeeRepository;
            }

            [HttpGet]
            [Route("{id:int}")]
            public async Task<IActionResult> GetEmployee(int id)
            {
                var employee = await _employeeService.GetEmployeeDetails(id);
                if (employee == null)
                {
                    return NotFound($"No Employee Found for that {id}");
                }
                return Ok(employee);
            }
            [HttpPost]
            [Route("create")]
            public async Task<IActionResult> CreateEmployee([FromBody] EmployeeCreateRequestModel model)
            {
            var employee = await _employeeRepository.GetEmployeeByName(model.Name);
            if (employee!=null)
            {
                return NotFound($"{model.Name} => This user already exists.");
            }
            var newEmployee = await _employeeService.CreateEmployee(model);
                
                return Ok(newEmployee);
        }
            
              //"id": 16,
              //"name": "Roger Chen",
              //"password": "pii145!",
              //"designation": "Executive Assistant"


            [HttpPut]
            [Route("update")]
            public async Task<IActionResult> UpdateEmployee(EmployeeUpdateRequestModel model)
            {
                var employee = await _employeeService.GetEmployeeDetails(model.Id);
                if (employee == null)
                {
                    return NotFound($"{model.Id} not exists.");
                }
                var newEmployee = await _employeeService.UpdateEmployee(model);

                return Ok(newEmployee);
            }
            [HttpDelete]
            [Route("{id:int}/delete")]
            public async Task<IActionResult> DeleteEmployee(int id)
            {
                var employee = await _employeeService.DeleteEmployee(id);
                if (employee == null)
                {
                    return BadRequest("Delete Employee Failed");
                }
                return Ok(employee);
            }
            [HttpGet]
            [Route("listall")]
            public async Task<IActionResult> GetAllEmployees()
            {
                var employees = await _employeeRepository.GetAllEmployees();
                return Ok(employees);
            }

    }
}
