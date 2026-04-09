using PortfolioFer.Features.Projects.Dtos;
using PortfolioFer.Features.Projects.Repositories;

namespace PortfolioFer.Features.Projects.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _repository;

        public ProjectService(IProjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProjectResponseDto>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<ProjectResponseDto> GetById(int id)
        {
            var project = await _repository.GetById(id);

            if (project == null)
                throw new Exception("Project not found");

            return project;
        }

        public async Task Create(CreateProjectRequestDto request)
        {
            var project = new ProjectResponseDto
            {
                Name = request.Name,
                Description = request.Description,
                GithubUrl = request.GithubUrl
            };

            await _repository.Create(project);
        }
    }
}