using PortfolioFer.Database.Entities;
using PortfolioFer.Features.Projects.Dtos;

namespace PortfolioFer.Features.Projects.Repositories
{
    public interface IProjectRepository
    {
        Task<List<ProjectResponseDto>> GetAll();
        Task<ProjectResponseDto> GetById(int id);
        Task Create(Project project);
        Task<bool> Delete(int id);
    }
}
