using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.Queries.GetAllSkills;
using DevFreela.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SkillsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllSkillQuery();

            var skills = await _mediator.Send(query);

            return Ok(skills);
        }
    }
}