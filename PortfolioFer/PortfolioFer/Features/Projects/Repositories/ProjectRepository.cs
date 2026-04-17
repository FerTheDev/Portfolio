using Microsoft.EntityFrameworkCore;
using PortfolioFer.Database.Context;
using PortfolioFer.Database.Entities;
using PortfolioFer.Features.Projects.Dtos;

namespace PortfolioFer.Features.Projects.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProjectResponseDto>> GetAll()
        {
            return await _context.Projects
                .Select(p => new ProjectResponseDto
                {
                    Id = p.Id,
                    Name = p.Title,
                    Description = p.Description,
                    GithubUrl = p.Link
                })
                .ToListAsync();
        }

        public async Task<ProjectResponseDto> GetById(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null) return null;

            return new ProjectResponseDto
            {
                Id = project.Id,
                Name = project.Title,
                Description = project.Description,
                GithubUrl = project.Link
            };
        }

        public async Task Create(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
                return false;

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}