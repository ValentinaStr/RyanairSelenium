using System.Reflection;
using Ryanair.Flight;

namespace Ryanair
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Assembly assem = typeof(LoggerTXT.LoggerServiceTXT).Assembly;  
			 var myLoggerTxt = (LoggerTXT.LoggerServiceTXT)assem.CreateInstance("LoggerTXT.LoggerServiceTXT");

			Assembly assem1 = typeof(LoggerXML.LoggerServiceXML<DataFlight>).Assembly;	
			Type closed = typeof(LoggerXML.LoggerServiceXML<DataFlight>);
			var myLoggerXml = (LoggerXML.LoggerServiceXML<DataFlight>)assem1.CreateInstance("LoggerXML.LoggerServiceXML`1[[Ryanair.Flight.DataFlight, Ryanair]]");

			HomePage home = new HomePage();
            home.AgreeWithUsingCookies();
            home.InputDepartureStation("Vilnius");
            home.InputDestinationStation("Barcelona");
            home.ChooseDayCurrentMonth("2023-06-16");
            home.ChooseDayCurrentMonth("2023-06-30");
            home.AddAdultPassenger(1);
            home.AddChildrenPassenger(1);
            home.ConfirmSelection();

            FlightSelect flightSelect = new FlightSelect();
            flightSelect.ChoiceSelectFrom();
            flightSelect.ChoiceSelectTo();
            flightSelect.ChoiceTypeFamilyPlus();
            flightSelect.ChoiceButtonBasket();

           myLoggerXml.WriteLog(flightSelect.GetDataFlight());
		   myLoggerTxt.WriteLog(flightSelect.GetDataFlight().GetDataFlightTXT());
			//flightSelect.GetInformationAboutFlightInTheBasket();
			//flightSelect.GetInformationAboutFlightXml();
			//flightSelect.GetInformationAboutFlightTXT();
           flightSelect.LogInformationAboutFlightDataBase();

           home.DriverClose();
        }
    }
}