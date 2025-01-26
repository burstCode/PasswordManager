using System;
using System.Diagnostics.Eventing.Reader;

namespace PasswordManager
{
    public class Logger
    {
        private string logFilePath;

        // При создании объекта логгера создается файл для конкретного запуска программы
        public Logger()
        {
            string directoryPath = "logs";

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            logFilePath = $@"{directoryPath}\log_{timestamp}.txt";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (File.Create(logFilePath)) { }
        }

        public void Log(string message, LogType logType = LogType.Information)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{logType}] {message}";

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(logEntry);
            }
        }
    }

    public enum LogType
    {
        Information,
        Warning,
        Error
    }
}
