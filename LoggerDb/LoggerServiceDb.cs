using ILogger;

namespace LoggerDb
{
    public class LoggerServiceDb : ILog
    {
        public void Log(ILogData dataToLog)
        {
            using var db = ApplicationDbContext.GetApplicationContext();
            {
				(DateTime departDayTimeFrom, string departCityFrom, DateTime departDayTimeTo, string departCityTo,
			    DateTime returnDayTimeFrom, string returnCityFrom, DateTime returnDayTimeTo, string returnCityTo,
                string costGeneral) = dataToLog;
				
				LogDbModel model = new(departDayTimeFrom, departCityFrom,departDayTimeTo, departCityTo,
                                       returnDayTimeFrom, returnCityFrom,  returnDayTimeTo,  returnCityTo,
                                       costGeneral);

                db.dataDbModel.Add((LogDbModel)model);
                db.SaveChanges();
            }
        }
    }
}
