using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleConsoleLogger
{
    public static class ConsoleLogger
    {
        private readonly static StringBuilder log = new StringBuilder();
        public static List<Line> lines = new List<Line>();

        public static void Log(string message)
        {
            LogMessage(message, ConsoleColor.White, Level.Normal);
        }

        public static void LogSuccess(string message)
        {
            LogMessage(message, ConsoleColor.Green, Level.Success);
        }

        public static void LogException(Exception exception, bool exitApplication = false)
        {
            LogMessage(exception.Message, ConsoleColor.Red, Level.Error);
            LogMessage(exception.StackTrace, ConsoleColor.Red, Level.Error);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        public static void LogError(string message, bool exitApplication = false)
        {
            LogMessage(message, ConsoleColor.Red, Level.Error);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        public static void LogWarning(string warning)
        {
            LogMessage(warning, ConsoleColor.Yellow, Level.Warning);
        }

        public static void LogSilent(string message)
        {
            LogMessage(message, ConsoleColor.White, Level.Silent);
        }

        public static string GetLogsRawString()
        {
            return log.ToString();
        }

        public static Line[] GetLogs()
        {
            return lines.ToArray();
        }

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
