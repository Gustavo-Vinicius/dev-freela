using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}