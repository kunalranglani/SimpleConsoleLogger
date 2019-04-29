using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleConsoleLogger
{
    // Static logger for the app
    public static class ConsoleLogger
    {
        private readonly static StringBuilder log = new StringBuilder();
        private static List<Line> lines = new List<Line>();

        /// <summary>
        /// Logs a message to the console in white color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(string message)
        {
            LogMessage(message, ConsoleColor.White, Level.Normal);
        }

        /// <summary>
        /// Logs a message to the console in green color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogSuccess(string message)
        {
            LogMessage(message, ConsoleColor.Green, Level.Success);
        }

        /// <summary>
        /// Logs an exception to the console in red color.
        /// </summary>
        /// <param name="exception">The exception to log.</param>
        /// <param name="exitApplication">Exit the application.</param>
        public static void LogException(Exception exception, bool exitApplication = false)
        {
            LogMessage(exception.Message, ConsoleColor.Red, Level.Error);
            LogMessage(exception.StackTrace, ConsoleColor.Red, Level.Error);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        /// <summary>
        /// Logs a message to the console in red color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="exitApplication">Exit the application.</param>
        public static void LogError(string message, bool exitApplication = false)
        {
            LogMessage(message, ConsoleColor.Red, Level.Error);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        /// <summary>
        /// Logs a message to the console in yellow color.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogWarning(string warning)
        {
            LogMessage(warning, ConsoleColor.Yellow, Level.Warning);
        }

        /// <summary>
        /// Log a silent message to the logs but does not output to console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogSilent(string message)
        {
            LogMessage(message, ConsoleColor.White, Level.Silent);
        }

        /// <summary>
        /// Gets a string value to all the messages that have been logged.
        /// </summary>
        /// <returns></returns>
        public static string GetLogsRawString()
        {
            return log.ToString();
        }

        /// <summary>
        /// Gets am array of all lines that have been logged.
        /// </summary>
        /// <returns></returns>
        public static Line[] GetLogs()
        {
            return lines.ToArray();
        }

        /// <summary>
        /// Saves the logs logged so far to a file.
        /// </summary>
        /// <param name="logFileFullPath">The full file path including file name.</param>
        public static void LogToFile(string logFileFullPath)
        {
            try
            {
                File.WriteAllText(logFileFullPath, log.ToString());

                LogSuccess($"Log file : {logFileFullPath}");
            }
            catch
            {
                LogError($"An error occurred while writing log to file {logFileFullPath}");
            }
        }

        private static void LogMessage(string message, ConsoleColor color, Level level)
        {
            Console.ForegroundColor = color;
            log.AppendLine(message);
            LogLine(message, color.ToString(), level);

            if (level != Level.Silent)
            {
                Console.WriteLine(message);
            }

            Console.ResetColor();
        }

        private static void LogLine(string message, string color, Level level)
        {
            Line line = new Line()
            {
                Color = color,
                Message = message,
                Level = level
            };

            lines.Add(line);
        }

        private static void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
