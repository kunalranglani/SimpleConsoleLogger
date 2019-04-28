using System;

namespace SimpleConsoleLogger
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            ConsoleLogger.Log(message);
        }

        public void LogSuccess(string message)
        {
            ConsoleLogger.LogSuccess(message);
        }

        public void LogException(Exception exception, bool exitApplication = false)
        {
            ConsoleLogger.LogException(exception, exitApplication);
        }

        public void LogError(string message, bool exitApplication = false)
        {
            ConsoleLogger.LogError(message, exitApplication);
        }

        public void LogWarning(string warning)
        {
            ConsoleLogger.LogWarning(warning);
        }

        public void LogSilent(string message)
        {
            ConsoleLogger.LogSilent(message);
        }

        public void LogToFile(string logFileFullPath)
        {
            ConsoleLogger.LogToFile(logFileFullPath);
        }

        public string GetLogsRawString()
        {
            return ConsoleLogger.GetLogsRawString();
        }

        public Line[] GetLogs()
        {
            return ConsoleLogger.GetLogs();
        }
    }
}
