using System;

namespace SimpleConsoleLogger
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Static.Logger.Log(message);
        }

        public void LogSuccess(string message)
        {
            Static.Logger.LogSuccess(message);
        }

        public void LogException(Exception exception, bool exitApplication = false)
        {
            Static.Logger.LogException(exception, exitApplication);
        }

        public void LogError(string message, bool exitApplication = false)
        {
            Static.Logger.LogError(message, exitApplication);
        }

        public void LogWarning(string warning)
        {
            Static.Logger.LogWarning(warning);
        }

        public void LogSilent(string message)
        {
            Static.Logger.LogSilent(message);
        }

        public void LogToFile(string logFileFullPath)
        {
            Static.Logger.LogToFile(logFileFullPath);
        }
    }
}
