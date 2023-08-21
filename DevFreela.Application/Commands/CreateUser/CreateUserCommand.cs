using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace DevFreela.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}