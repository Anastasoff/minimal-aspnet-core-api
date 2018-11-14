using Microsoft.AspNetCore.Mvc;

namespace MinimalAspNetCoreApi.Controllers
{
    [ApiController]
    [Route("")]
    [Route("ping")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
