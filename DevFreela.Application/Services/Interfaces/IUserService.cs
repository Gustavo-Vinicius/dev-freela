using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {
        UserViewModel GetUser(int id);
        int Create(CreateUserInputModel inputModel);
    }
}