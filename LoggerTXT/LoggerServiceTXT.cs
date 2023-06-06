using ILogger;

namespace LoggerTXT
{
    public  class LoggerServiceTXT : ILog
    {
        private const string PATH = @"D:\projects\dotnet\SeleniumRyanair\MyLog.txt";

        public LoggerServiceTXT()
        {
            File.WriteAllText(PATH, string.Empty);
        }

        public void Log(string message)
        {
            using StreamWriter sw = new(PATH, true, System.Text.Encoding.Default);
            sw.WriteLineAsync(message);
        }
    }
}
