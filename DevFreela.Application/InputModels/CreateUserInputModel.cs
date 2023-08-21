using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}