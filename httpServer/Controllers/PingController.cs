using Microsoft.AspNetCore.Http;
using GenHTTP;
using Microsoft.AspNetCore.Mvc;

namespace httpServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
