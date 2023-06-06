using System.Xml.Linq;
using ILogger;

namespace LoggerXML
{
    public class LoggerServiceXML : ILog
	{
        private string PATH = @"D:\projects\dotnet\SeleniumRyanair\LogXML.xml";


		public LoggerServiceXML()
		{
		}

		public void Log(string dataToLog)
        {
			string[] flight = dataToLog.Split(" ");
			
			var xmlTree = new XElement("Flight", new XAttribute("Price", flight[16]),
				new XElement("FlightDepard",
					new XElement("DayTime", flight[0]+ flight[1]+ flight[2]),
					//new XElement("Time", flight[6]),
					new XElement("City", flight[3]),
					new XElement("Day", flight[4] + flight[5] + flight[6]),
					//new XElement("Time", flight[20]),
					new XElement("City", flight[7])
				),
				new XElement("FlightReturn",
					new XElement("Day", flight[8] + flight[9] + flight[10]),
					//new XElement("Time", flight[34]),
					new XElement("City", flight[11]),
					new XElement("Day", flight[12] + flight[13] + flight[14]),
					//new XElement("Time", flight[48]),
					new XElement("City", flight[15])
				));

			using StreamWriter writer = new StreamWriter(PATH);
			writer.Write(xmlTree);
		}
    }
}
