using Microsoft.AspNetCore.Http;
using GenHTTP;
using Microsoft.AspNetCore.Mvc;

namespace httpServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test([FromBody] string requestBody)
        {
            if (requestBody == null)
            {
                return BadRequest("Missing request body");
            }

            return Ok(requestBody + " (test string)");
        }
    }
}
