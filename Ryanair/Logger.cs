using System.Reflection;
using DataSelectFlight;
using ILogger;

namespace Ryanair
{
	internal class LoggerManager
	{

		private List<ILog> loggers = new();
		public LoggerManager(string fileName)
		{
			using var reader = new StreamReader(fileName);

			string? line;
			while ((line = reader.ReadLine()) != null)
			{
				var assem = Assembly.LoadFrom(line);

				Type types = assem.GetExportedTypes()[0];

				if (types.GetInterface("ILog") != null)
				{
					loggers.Add((ILog)assem.CreateInstance(types.ToString()));
				}

			}
		}

		public void CreateLog(ILogData dataToLog)
		{
			foreach (ILog myLogger in loggers)
			{
				myLogger.Log(dataToLog);
			}


			/*public static Type[] search()
			{
				using var reader = new StreamReader(@"D:\projects\dotnet\SeleniumRyanair\Ryanair\LoggerDll.txt");

				string? line;
				while ((line = reader.ReadLine()) != null)
				{
					var assem = Assembly.LoadFrom(line);

					Type[] types = assem.GetTypes();
				}
				return types;
			}*/
		}
	}

}