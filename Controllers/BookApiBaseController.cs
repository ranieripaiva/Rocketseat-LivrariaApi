using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookApiBaseController : ControllerBase
{
    public string Autor { get; set; } = "Welisson Arley";

    [HttpGet("available")]
    public IActionResult Available()
    {
        return Ok("It`s available");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
