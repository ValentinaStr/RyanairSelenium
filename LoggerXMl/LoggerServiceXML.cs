using System.Xml.Serialization;
using ILogger;

namespace LoggerXML
{
    public class LoggerServiceXML : ILog
	{
        private string PATH = @"D:\projects\dotnet\SeleniumRyanair\LogXML.xml";

		public LoggerServiceXML()
		{
		}
		public void Log(ILogData dataToLog)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(dataToLog.GetType());
			using (TextWriter writer = new StreamWriter(PATH))
			{
				xmlSerializer.Serialize(writer, dataToLog);
			}
		}
	}
}
