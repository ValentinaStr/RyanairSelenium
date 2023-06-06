using ILogger;
using DataSelectFlight;

namespace LoggerDb
{
    public class LoggerServiceDb : ILog
    {
        public void Log(string dataToLog)
        {
            using (var db = ApplicationDbContext.GetApplicationContext())
            {
				string[] flight = dataToLog.Split(" ");

				var dayTimeDepartFrom = DateTime.Parse(flight[5] + " " + flight[6], System.Globalization.CultureInfo.InvariantCulture);
				var dayTimeDepartTo = DateTime.Parse(flight[19] + " " + flight[20], System.Globalization.CultureInfo.InvariantCulture);
				var dayTimeReturnFrom = DateTime.Parse(flight[33] + " " + flight[34], System.Globalization.CultureInfo.InvariantCulture);
				var dayTimeReturnTo = DateTime.Parse(flight[47] + " " + flight[48], System.Globalization.CultureInfo.InvariantCulture);

				var flightDataToLog = new DataFlight(new(dayTimeDepartFrom, flight[12], dayTimeDepartTo, flight[26]), 
					                                new(dayTimeReturnFrom, flight[40], dayTimeReturnTo, flight[54]),
                                                    flight[56]);

				db.dataFlights.Add(flightDataToLog);
                db.SaveChanges();
            }
        }
    }
}
