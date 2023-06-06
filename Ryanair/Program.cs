namespace Ryanair
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            HomePage home = new HomePage();
            home.AgreeWithUsingCookies();
            home.InputDepartureStation("Vilnius");
            home.InputDestinationStation("Barcelona");
            home.ChooseDayCurrentMonth("2023-07-14");
            home.ChooseDayCurrentMonth("2023-07-21");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(1);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeFamilyPlus();
            flightSelect.OpenBasket();

			Logger.CreateLog(flightSelect.GetDataFlight().GetDataFlightTXT());

			home.DriverClose();
        }
    }
}