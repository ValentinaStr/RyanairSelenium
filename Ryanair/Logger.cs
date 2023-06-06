using System.Reflection;
using ILogger;

namespace Ryanair
{
	internal  static class Logger
	{
		public static void CreateLog(string name, string message)
		{
			var sr = new StreamReader(@"D:\projects\dotnet\SeleniumRyanair\Ryanair\LoggerDll");

			var assem = Assembly.LoadFrom(name);
			Type[] types = assem.GetTypes();
			foreach (Type type in types)
			{
				if (type.GetInterface("ILog") != null)
				{
					var myLogger = (ILog)assem.CreateInstance(type.ToString());
					myLogger.Log(message);
				}
			}
		}
	}
}
