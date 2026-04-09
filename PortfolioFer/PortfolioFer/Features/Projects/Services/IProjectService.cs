using PortfolioFer.Features.Projects.Dtos;

namespace PortfolioFer.Features.Projects.Services
{
    public interface IProjectService
    {
        Task<List<ProjectResponseDto>> GetAll();
        Task<ProjectResponseDto> GetById(int id);
        Task Create(CreateProjectRequestDto request);
    }
}
