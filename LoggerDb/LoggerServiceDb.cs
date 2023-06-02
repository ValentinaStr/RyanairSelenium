using ILogger;

namespace LoggerDb
{

    public class LoggerServiceDb : ILog
    {
        public void Log(string dataFlight)
        {
            /*using (var db = ApplicationDbContext.GetApplicationContext())
            {
                DataFlight data = dataFlight as DataFlight;
                db.dataFlights.Add(data);
                db.SaveChanges();
            }*/
        }
    }
}
