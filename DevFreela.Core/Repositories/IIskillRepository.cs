using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;

namespace DevFreela.Core.Repositories
{
    public interface IIskillRepository
    {
        Task<List<SkillDTO>> GetAllAsync();
    }
}