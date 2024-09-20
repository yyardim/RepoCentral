using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RepoCentral.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class RepoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from RepoController");
    }
}
