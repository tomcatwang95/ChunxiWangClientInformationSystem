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
    public class InteractionController: ControllerBase
    {
        private readonly IInteractionService _interactionService;
        private readonly IInteractionRepository _interactionRepository;
        public InteractionController(IInteractionService interactionService, IInteractionRepository interactionRepository)
        {
            _interactionService = interactionService;
            _interactionRepository = interactionRepository;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetInteraction(int id)
        {
            var interaction = await _interactionService.GetInteractionDetails(id);
            if (interaction == null)
            {
                return NotFound($"No Interaction Found for that {id}");
            }
            return Ok(interaction);
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateInteraction([FromBody] InteractionCreatRequestModel model)
        {
            var interaction = await _interactionRepository.GetInteractionByCombination(model.EmpId, model.ClientId);
            if (interaction != null)
            {
                return NotFound("This Interaction already exists.");
            }
            var newInteraction = await _interactionService.CreateInteraction(model);

            return Ok(newInteraction);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateInteraction(InteractionUpdateRequestModel model)
        {
            var interaction = await _interactionService.GetInteractionDetails(model.Id);
            if (interaction == null)
            {
                return NotFound($"{model.Id} not exists.");
            }
            var newInteraction = await _interactionService.UpdateInteraction(model);

            return Ok(newInteraction);
        }
        [HttpDelete]
        [Route("{id:int}/delete")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var interaction = await _interactionService.DeleteInteraction(id);
            if (interaction == null)
            {
                return BadRequest("Delete interaction Failed");
            }
            return Ok(interaction);
        }
        [HttpGet]
        [Route("listall")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var interactions = await _interactionRepository.GetAllInteraction();
            return Ok(interactions);
        }
    }
}
