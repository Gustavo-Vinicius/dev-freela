using Dapper;
using DevFreela.Core.DTOs;
using DevFreela.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence.Repositories
{
    public class IskillRepository : IIskillRepository
    {
        private readonly DevFreelaDbContext _dbContext;
        public IskillRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<SkillDTO>> GetAllAsync()
        {
            var script = "SELECT Id, Description FROM Skills";

            var skills = await _dbContext.Database.GetDbConnection().QueryAsync<SkillDTO>(script);

            return skills.ToList();
        }
    }
}