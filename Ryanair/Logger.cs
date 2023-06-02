using System.Reflection;
using ILogger;

namespace Ryanair
{
	internal  static class Logger
	{
		public static void CreateLog(string name, string message)
		{
			var assem = Assembly.LoadFrom(name);
			Type[] types = assem.GetTypes();
			var typeName = types[3].ToString();
			var myLogger = (ILog)assem.CreateInstance(typeName);
			myLogger.Log(message);
		}

	}
}
