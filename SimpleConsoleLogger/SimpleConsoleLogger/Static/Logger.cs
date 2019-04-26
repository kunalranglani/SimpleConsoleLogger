using System;
using System.IO;
using System.Text;

namespace SimpleConsoleLogger.Static
{
    public static class Logger
    {
        private readonly static StringBuilder log = new StringBuilder();

        public static void Log(string message)
        {
            LogMessage(message, ConsoleColor.White);
        }

        public static void LogSuccess(string message)
        {
            LogMessage(message, ConsoleColor.Green);
        }

        public static void LogException(Exception exception, bool exitApplication = false)
        {
            LogMessage(exception.Message, ConsoleColor.Red);
            LogMessage(exception.StackTrace, ConsoleColor.Red);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        public static void LogError(string message, bool exitApplication = false)
        {
            LogMessage(message, ConsoleColor.Red);

            if (exitApplication)
            {
                ExitApplication();
            }
        }

        public static void LogWarning(string warning)
        {
            LogMessage(warning, ConsoleColor.Yellow);
        }

        public static void LogSilent(string message)
        {
            log.AppendLine(message);
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

        private static void LogMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            LogSilent(message);
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ExitApplication()
        {
            Environment.Exit(0);
        }
    }
}
