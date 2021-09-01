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

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientService clientService, IClientRepository clientRepository)
        {
            _clientService = clientService;
            _clientRepository = clientRepository;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _clientService.GetClientDetail(id);
            if (employee == null)
            {
                return NotFound($"No Client Found for that {id}");
            }
            return Ok(employee);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateClient([FromBody] ClientCreateRequestModel model)
        {
            var client = await _clientRepository.GetClientByName(model.Name);
            if (client != null)
            {
                return NotFound($"{model.Name} => This user already exists.");
            }
            var newClient = await _clientService.CreateClient(model);

            return Ok(newClient);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateClient(ClientUpdateRequestModel model)
        {
            var client = await _clientService.GetClientDetail(model.Id);
            if (client == null)
            {
                return NotFound($"{model.Id} not exists.");
            }
            var newClient = await _clientService.UpdateClient(model);

            return Ok(newClient);
        }
        [HttpDelete]
        [Route("{id:int}/delete")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _clientService.DeleteClient(id);
            if (client == null)
            {
                return BadRequest("Delete Client Failed");
            }
            return Ok(client);
        }
        [HttpGet]
        [Route("listall")]
        public async Task<IActionResult> GetAllClients()
        {
            var clients = await _clientRepository.GetAllClients();
            return Ok(clients);
        }
    }
}
