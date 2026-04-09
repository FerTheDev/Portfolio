using PortfolioFer.Features.Projects.Dtos;

namespace PortfolioFer.Features.Projects.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private static List<ProjectResponseDto> _projects = new();

        public Task<List<ProjectResponseDto>> GetAll()
        {
            return Task.FromResult(_projects);
        }

        public Task<ProjectResponseDto> GetById(int id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(project);
        }

        public Task Create(ProjectResponseDto project)
        {
            project.Id = _projects.Count + 1;
            _projects.Add(project);

            return Task.CompletedTask;
        }
    }
}