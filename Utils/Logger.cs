using System;
using System.IO;

namespace SecurityMonitoringSystem.Utils
{
    public class Logger
    {
        private static readonly string LogFilePath = "auth.log";

        public static void Log(string message)
        {
            string log = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message}";
            File.AppendAllText(LogFilePath, log + Environment.NewLine);
        }
    }
}
