using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Infrastructure.Persistence;
using MediatR;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartProjectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        public StartProjectCommandHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project?.Start();

            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}