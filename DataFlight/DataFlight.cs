using System.Text;
using ILogger;

namespace DataSelectFlight 
{ 

	public class DataFlight : ILogData
    {        
        public FlightDetails FlightDepart { get; set; } 
		public FlightDetails FlightReturn { get; set; }
		public string CostGeneral { get; set; }

        public DataFlight(FlightDetails flightDepart, FlightDetails flightReturn, string costGeneral)
        {
            FlightDepart = flightDepart;
            FlightReturn = flightReturn;
            CostGeneral = costGeneral;
        }

        public DataFlight()
        {
        }

		public void Deconstruct(out DateTime departDayTimeFrom, out string departCityFrom, out DateTime departDayTimeTo, out string departCityTo,
			out DateTime returnDayTimeFrom, out string returnCityFrom, out DateTime returnDayTimeTo, out string returnCityTo, out string costGeneral)
		{
			departDayTimeFrom = FlightDepart.DayTimeFrom;
            departCityFrom = FlightDepart.CityFrom;
            departDayTimeTo = FlightDepart.DayTimeTo;
			departCityTo = FlightDepart.CityTo;
			returnDayTimeFrom = FlightReturn.DayTimeFrom;
			returnCityFrom = FlightReturn.CityFrom;
			returnDayTimeTo = FlightReturn.DayTimeTo;
			returnCityTo = FlightReturn.CityTo;
			costGeneral = CostGeneral;
		}

		public  override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(FlightDepart.GetFlightDetailsTXT());
            sb.Append(FlightReturn.GetFlightDetailsTXT());
            sb.Append(CostGeneral);
            return sb.ToString();
        }
    }
}
