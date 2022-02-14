using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;

namespace FunctionAppAPI
{
    public class NullLoggerTest : ILogger
    {
        public string logInfo { get; set; }
        private NullLogger log = null;

        public NullLoggerTest()
        {
            log = NullLogger.Instance;
        }

        public void LogInformation(string msg)
        {
            logInfo = msg;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            LogInformation(formatter.Invoke(state, exception));
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return log.BeginScope(state);
        }
    }
}
