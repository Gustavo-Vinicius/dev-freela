using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task InputDataIsOk_Executed_ReturnProjectId()
        {
            // Arrange
            var projectRepository = new Mock<IProjectRepository>();

            var createProjectCommand = new CreateProjectCommand{
                Title = "Titulo Teste",
                Description = "Uma descricao daora",
                TotalCost = 50000,
                IdClient = 1,
                IdFreelancer = 2

            };

            var createProjectCommandHandler = new  CreateProjectCommandHandler(projectRepository.Object);
            // Act

            var id = await createProjectCommandHandler.Handle(createProjectCommand, new CancellationToken());
        
            // Assert

            Assert.True(id >= 0);

            projectRepository.Verify(pr => pr.AddAsync(It.IsAny<Project>()), Times.Once);
        }
    }
}