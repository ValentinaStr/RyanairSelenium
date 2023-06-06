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
