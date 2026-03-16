using Microsoft.AspNetCore.Mvc;

namespace PortfolioFer.Features.HelloWorld.Controllers;

[ApiController]
[Route("api/v1/hello-world")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}