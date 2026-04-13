using Microsoft.AspNetCore.Mvc;
using PortfolioFer.Features.Profile.Services;

namespace PortfolioFer.Features.Profile.Controllers
{
    [ApiController]
    [Route("profile")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _service;

        public ProfileController(IProfileService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var profile = await _service.Get();
            return Ok(profile);
        }
    }
}
