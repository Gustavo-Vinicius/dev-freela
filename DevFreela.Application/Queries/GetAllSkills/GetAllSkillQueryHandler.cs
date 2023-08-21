using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillQueryHandler : IRequestHandler<GetAllSkillQuery, List<SkillViewModel>>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetAllSkillQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SkillViewModel>> Handle(GetAllSkillQuery request, CancellationToken cancellationToken)
        {
            var skills = _dbContext.Skills;

            var skillViewModel = await skills
            .Select(s => new SkillViewModel(s.Id, s.Description)).ToListAsync();

            return skillViewModel;
        }
    }
}