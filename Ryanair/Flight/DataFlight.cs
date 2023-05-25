using System.Text;

namespace Ryanair.Flight
{
    public class DataFlight
    {
        public int Id { get; set; }
        public List<FlightDetails> flightDepartAndReturn { get; set; } = new();
        public string CostGeneral { get; set; }

        public DataFlight(FlightDetails flightDepart, FlightDetails flightReturn, string costGeneral)
        {
            flightDepartAndReturn = new() { flightDepart, flightReturn };
            CostGeneral = costGeneral;
        }

        public DataFlight()
        {
        }

        public string GetDataFlightTXT()
        {
            var sb = new StringBuilder();
            sb.Append(flightDepartAndReturn[0].GetFlightDetailsTXT());
            sb.Append(flightDepartAndReturn[1].GetFlightDetailsTXT());
            sb.Append(CostGeneral + "\n");
            return sb.ToString();
        }
    }
}
