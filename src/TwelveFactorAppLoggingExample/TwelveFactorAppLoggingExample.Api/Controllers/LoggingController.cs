using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TwelveFactorAppLoggingExample.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Info")]
        public IActionResult GetInfo()
        {
            var log = new LogResponse(LogLevel.Information);

            _logger.LogInformation(log.Message, log);

            return new OkObjectResult(log);
        }

        [HttpGet("Warning")]
        public IActionResult GetWarning()
        {
            var log = new LogResponse(LogLevel.Warning);

            _logger.LogWarning(log.Message, log);

            return new OkObjectResult(log);
        }

        [HttpGet("Error")]
        public IActionResult GetError()
        {
            var log = new LogResponse(LogLevel.Error);

            _logger.LogError(log.Message, log);

            return new OkObjectResult(log);
        }
    }
}
