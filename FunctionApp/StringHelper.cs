using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class StringHelper
    {        
        public static void LogMessage(ILogger log, string msg)
        {
            log.LogInformation(msg);
        }
    }
}
