using Microsoft.AspNetCore.Http;
using GenHTTP;
using Microsoft.AspNetCore.Mvc;

namespace httpServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    /// Тестовый контроллер
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Обработка get-запроса по адресу /test
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns>
        /// тело запроса + " (test string)"
        /// </returns>
        [HttpGet]
        public IActionResult Test([FromBody] string requestBody)
        {
            if (requestBody == null)
            {
                return BadRequest("Отсутствует тело запроса");
            }

            return Ok(requestBody + " (test string)");
        }
    }
}
