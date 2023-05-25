namespace LoggerTXT
{
    public  class LoggerServiceTXT : ILogTXT
    {
        private const string PATH = @"D:\projects\dotnet\Ira\MyLog.txt";

        public LoggerServiceTXT()
        {
            File.WriteAllText(PATH, string.Empty);
        }

        public void WriteLog(string message)
        {
            using StreamWriter sw = new(PATH, true, System.Text.Encoding.Default);
            sw.WriteLineAsync(message);
        }
    }
}
