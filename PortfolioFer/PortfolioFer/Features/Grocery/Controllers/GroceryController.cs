using Microsoft.AspNetCore.Mvc;
using PortfolioFer.Features.Grocery.Dtos;
using PortfolioFer.Features.Grocery.Services;

namespace PortfolioFer.Features.Grocery.Controllers
{
    [ApiController]
    [Route("grocery")]
    public class GroceryController : ControllerBase
    {
        private readonly IGroceryService _service;

        public GroceryController(IGroceryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _service.GetById(id);

            if (result == null)
                return NotFound("Item not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGroceryItemRequestDto request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name))
                return BadRequest("Name is required");

            var result = await _service.Create(request);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateGroceryItemRequestDto request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Name))
                return BadRequest("Name is required");

            var result = await _service.Update(id, request);

            if (result == null)
                return NotFound("Item not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await _service.Delete(id);

            if (!success)
                return NotFound("Item not found");

            return Ok();
        }

        [HttpPatch("{id}/toggle")]
        public async Task<IActionResult> ToggleComplete(Guid id)
        {
            var result = await _service.ToggleComplete(id);

            if (result == null)
                return NotFound("Item not found");

            return Ok(result);
        }
    }
}