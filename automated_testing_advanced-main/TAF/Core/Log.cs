using OpenQA.Selenium;
using Serilog;
using Serilog.Events;

namespace Core
{
    public static class Log
    {
        public static ILogger Logger { get; set; }

        public static void Debug(string messageTempplate)
        {
            Logger.Write(LogEventLevel.Debug, messageTempplate);
        }
        public static void Information(string messageTemplate)
        {
            Logger.Write(LogEventLevel.Information, messageTemplate);
        }
        public static void Information(string messageTempplate, By by)
        {
            Logger.Write(LogEventLevel.Information, messageTempplate, by);
        }
        public static void Error(string messageTemplate,By by)
        {
            Logger.Write(LogEventLevel.Error, messageTemplate,by);
        }

    }
}