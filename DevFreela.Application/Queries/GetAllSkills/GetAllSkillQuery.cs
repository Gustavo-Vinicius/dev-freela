using DevFreela.Core.DTOs;
using MediatR;

namespace DevFreela.Application.Queries.GetAllSkills
{
    public class GetAllSkillQuery : IRequest<List<SkillDTO>>
    {
        
    }
}