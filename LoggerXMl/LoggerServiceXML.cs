using System.Xml.Serialization;

namespace LoggerXML
{
    public class LoggerServiceXML<T> : ILogXML<T>
    {
        private const string PATH = @"D:\projects\dotnet\SeleniumRyanair\LogXML.xml";
		public void WriteLog(T dataToLog)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(PATH))
            {
                xmlSerializer.Serialize(writer, dataToLog);
            }
        }
    }
}
