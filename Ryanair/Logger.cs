using System.Linq;
using System.Reflection;
using DataSelectFlight;
using ILogger;

namespace Ryanair
{
	internal  static class Logger
	{
		public static void CreateLog(DataFlight message)
		{
			using var reader = new StreamReader(@"D:\projects\dotnet\SeleniumRyanair\Ryanair\LoggerDll.txt");

			string? line;
			while ((line = reader.ReadLine()) != null)
			{
				var assem = Assembly.LoadFrom(line);

				Type[] types = assem.GetTypes();
				
				foreach (Type t in types)
				{
					if (t.GetInterface("ILog") != null)
					{		
						var myLogger = (ILog)assem.CreateInstance(t.ToString());
						myLogger.Log(message);
					}
				}
			}
		}
	}
}
