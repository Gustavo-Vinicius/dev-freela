using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Queries.GetProjectById
{
    public class GetProjectByIdQuery : IRequest<ProjectDetailsViewModel>
    {
        
    }
}