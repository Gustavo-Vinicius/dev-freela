using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.API.Model;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
            var id = _userService.Create(inputModel);

            //return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
            return Ok();
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