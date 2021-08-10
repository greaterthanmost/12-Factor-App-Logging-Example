using System;
using Microsoft.Extensions.Logging;

namespace TwelveFactorAppLoggingExample.Api
{
    public class LogResponse
    {
        public LogResponse(LogLevel level)
        {
            Level = level.ToString();
            Message = $"Logging an {level} level log at {DateTime.Now.TimeOfDay}.";
        }

        public string Level { get; set; }

        public string Message { get; set; }
    }
}
