using Microsoft.AspNetCore.Mvc;
using PortfolioFer.Features.Projects.Dtos;
using PortfolioFer.Features.Projects.Services;

namespace PortfolioFer.Features.Projects.Controllers
{
    [ApiController]
    [Route("projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _service;

        public ProjectsController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projects = await _service.GetAll();
            return Ok(projects);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var project = await _service.GetById(id);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProjectRequestDto request)
        {
            await _service.Create(request);
            return Ok();
        }
    }
}
