using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartProjectCommand : IRequest<Unit>
    {
        public StartProjectCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}