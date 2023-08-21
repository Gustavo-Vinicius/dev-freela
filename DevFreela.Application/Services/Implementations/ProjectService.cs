using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbcontext;
        public ProjectService(DevFreelaDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbcontext.Projects
            .Include(p => p.Client)
            .Include(p => p.Freelancer)
            .SingleOrDefault(p => p.Id == id);

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.StartedAt,
                project.FinishedAt,
                project.Client.FullName,
                project.Freelancer.FullName
            );

            return projectDetailsViewModel;
        }
    }
}