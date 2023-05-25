using static Ryanair.XpathRyanair;
using Ryanair.Flight;
using Ryanair.LoggerServices;

namespace Ryanair
{
    public class FlightSelect : BasePage
    {
        public FlightSelect() : base()
        {

        }
        public void ChoiceSelectFrom()
        {
            FindElementsWithWaiter(CHOICE_SELECT)[0].Click();
        }

        public void ChoiceSelectTo()
        {
            FindElementsWithWaiter(CHOICE_SELECT)[1].Click();
        }

        public void ChoiceTypeValue() 
        {
            FindElementWithWaiter(CHOICE_TYPE_VALUE).Click();
            FindElementWithWaiter(CONTINUE_VALUE).Click();
        }

        public void ChoiceTypeRegular() 
        {
            FindElementWithWaiter(CHOICE_TYPE_REGULAR).Click();
        }

        public void ChoiceTypePlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_PLUS).Click();
        }

        public void ChoiceTypeFlexiPlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_FLEXI_PLUS).Click();
        }

        public void ChoiceTypeFamilyPlus()
        {
            FindElementWithWaiter(CHOICE_TYPE_FAMILY_PLUS).Click();
        }

        public void ChoiceButtonBasket() 
        {
            FindElementWithWaiter(BUTTON_BASKET).Click();
        }

        /*public void GetInformationAboutFlightInTheBasket() 
        {
            Log(FindElementWithWaiter(INFORMATION_ABOUT_FLIGHT_IN_THE_BASKET).Text);
        }

       public void GetInformationAboutFlightXml()
        {
            Log(GetDataFlight());
        }

       public void GetInformationAboutFlightTXT()
        {
            Log(GetDataFlight().GetDataFlightTXT());
        }*/

        public void LogInformationAboutFlightDataBase()
        {
            new LoggerServiceDb<DataFlight>().Create(GetDataFlight());
        }

        public DateTime GetDataTimeFlight(string XpathDate, string XpathTime)
        {
            string day = FindElementWithWaiter(XpathDate).GetAttribute("data-ref");
            var time = GetOnlyTimeFlight(XpathTime);
            string dayAndTime = day + " " + time;
            return DateTime.Parse(dayAndTime, System.Globalization.CultureInfo.InvariantCulture);
        }

        public string GetOnlyTimeFlight(string XpathTime)
        {
           return FindElementWithWaiter(XpathTime).Text.ToString().Split("\n")[0];
        }

        public string GetOnlyCityFlight(string XpathTime)
        {
            return FindElementWithWaiter(XpathTime).Text.ToString().Split("\n")[1];
        }

        public FlightDetails GetFlightDetails(string dayFrom, string timeAndCityFrom, string timeAndCityTo)
        {
            var detailsFlight = new FlightDetails();
            detailsFlight.DayTimeFrom = GetDataTimeFlight(dayFrom, timeAndCityFrom);
            detailsFlight.CityFrom = GetOnlyCityFlight(timeAndCityFrom);
            detailsFlight.DayTimeTo = GetDataTimeFlight(dayFrom, timeAndCityTo);
            detailsFlight.CityTo = GetOnlyCityFlight(timeAndCityTo);
            return detailsFlight;
        }
        public DataFlight GetDataFlight()
        {
            var departFlight = GetFlightDetails(GET_ONLY_DAY_DEPART, GET_TIME_AND_CITY_DEPART_FROM, GET_TIME_AND_CITY_ARRIVE_TO);
            var returnFlight = GetFlightDetails(GET_ONLY_DAY_RETURN, GET_TIME_AND_CITY_RETURN_FROM, GET_TIME_AND_CITY_RETURN_TO);
            string costGeneral = FindElementWithWaiter(GET_COST_GENERAL).Text.ToString();
            return new DataFlight(departFlight, returnFlight,costGeneral);
        }
    }
}
