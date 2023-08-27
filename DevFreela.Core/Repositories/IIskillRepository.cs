using DevFreela.Core.DTOs;

namespace DevFreela.Core.Repositories
{
    public interface IIskillRepository
    {
        Task<List<SkillDTO>> GetAllAsync();
    }
}