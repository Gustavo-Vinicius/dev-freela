using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.Model;
using DevFreela.Application.Commands.CreateUser;
using DevFreela.Application.InputModels;
using DevFreela.Application.Queries.GetUserById;
using DevFreela.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        private readonly IMediator _mediator;
        public UsersController(IUserService userService, IMediator mediator)
        {
            _userService = userService;
            _mediator = mediator;
        }

        // api/users/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = new GetUserByIdQuery(id);

            if (user == null)
            {
                return NotFound();
            }

            await _mediator.Send(user);

            return Ok(user);
        }

        // api/users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            // TODO: Para Módulo de Autenticação e Autorização

            return NoContent();
        }
    }
}