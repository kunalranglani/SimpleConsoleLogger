using System;

namespace SimpleConsoleLogger
{
    public interface ILogger
    {
        /// <summary>
        /// Logs a message to the console in white color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Log(string message);

        /// <summary>
        /// Logs a message to the console in green color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void LogSuccess(string message);

        /// <summary>
        /// Logs an exception to the console in red color.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="exitApplication">Exit the application.</param>
        void LogException(Exception exception, bool exitApplication = false);

        /// <summary>
        /// Logs a message to the console in red color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="exitApplication">Exit the application.</param>
        void LogError(string message, bool exitApplication = false);

        /// <summary>
        /// Logs a message to the console in yellow color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void LogWarning(string warning);

        /// <summary>
        /// Log a silent message to the logs but does not output to console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void LogSilent(string message);

        /// <summary>
        /// Saves the logs logged so far to a file.
        /// </summary>
        /// <param name="logFileFullPath">The full file path including file name.</param>
        void LogToFile(string logFileFullPath);

        /// <summary>
        /// Gets a string value to all the messages that have been logged.
        /// </summary>
        /// <returns></returns>
        string GetLogsRawString();

        /// <summary>
        /// Gets am array of all lines that have been logged.
        /// </summary>
        /// <returns></returns>
        Line[] GetLogs();
    }
}
