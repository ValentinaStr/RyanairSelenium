using DataSelectFlight;

namespace Ryanair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggerManager listAllLoggers = new(@"D:\projects\dotnet\SeleniumRyanair\Ryanair\LoggersDll.txt");
            HomePage home = new HomePage();
            home.AgreeWithUsingCookies();
            home.InputDepartureStation("Vilnius");
            home.InputDestinationStation("Barcelona");
            home.ChooseDayCurrentMonth("2023-07-07");
            home.ChooseDayCurrentMonth("2023-07-14");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(1);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeRegular();
            flightSelect.OpenBasket();
            listAllLoggers.CreateLog(flightSelect.GetDataFlight());
			//Logger.CreateLog(flightSelect.GetDataFlight());
			
			home.DriverClose();
        }
    }
}