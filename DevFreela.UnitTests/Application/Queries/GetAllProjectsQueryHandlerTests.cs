using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsQueryHandlerTests
    {
        [Fact]
        public async void ThreeProjectExist_Executed_ReturnThreeProjectViewModels()
        {
            //Arrange
            var project = new List<Project>{
                new Project("Nome do Teste 1", "Descricao de Teste 1", 1, 2, 10000),
                new Project("Nome do Teste 2", "Descricao de Teste 2", 1, 2, 20000),
                new Project("Nome do Teste 3", "Descricao de Teste 3", 1, 2, 30000),
            };

            var projectRepository = new Mock<IProjectRepository>();
            projectRepository.Setup(pr => pr.GetAllAsync().Result).Returns(project);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepository.Object);
 
            //Act

            var projectViewModelList = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            //Assert

            Assert.NotNull(projectViewModelList);
            Assert.NotEmpty(projectViewModelList);
            Assert.Equal(project.Count, projectViewModelList.Count);

            projectRepository.Verify(pr => pr.GetAllAsync().Result, Times.Once);
        }
    }
}