using System;

namespace SimpleConsoleLogger
{
    public interface ILogger
    {
        void Log(string message);

        void LogSuccess(string message);

        void LogException(Exception exception, bool exitApplication = false);

        void LogError(string message, bool exitApplication = false);

        void LogWarning(string warning);

        void LogSilent(string message);

        void LogToFile(string logFileFullPath);
    }
}
