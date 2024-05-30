using Microsoft.AspNetCore.Http;
using GenHTTP;
using Microsoft.AspNetCore.Mvc;

namespace httpServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    /// Пинг-понг для проверки работы веб-сервера
    public class PingController : ControllerBase
    {
        /// <summary>
        /// Обработка get-запроса по адресу /ping
        /// </summary>
        /// <returns>
        /// string "pong"
        /// </returns>
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
