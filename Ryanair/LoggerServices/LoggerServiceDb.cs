using LoggerDb;
using Ryanair.Flight;

namespace Ryanair.LoggerServices
{
    public class LoggerServiceDb<T>: ILogDb<T>
    {
        public void Create(T dataFlight)
        {
            using (var db = ApplicationDbContext.GetApplicationContext())
            {
                DataFlight data = dataFlight as DataFlight;
                db.dataFlights.Add(data);
                db.SaveChanges();
            }
        }
    }
}
