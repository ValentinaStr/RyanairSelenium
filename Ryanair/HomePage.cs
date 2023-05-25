using static Ryanair.XpathRyanair;

namespace Ryanair
{
    public class HomePage : BasePage
    {
        public HomePage() : base()
        {
            GoToUrl("https://www.ryanair.com/us/en");
        }

        public void InputDepartureStation(string nameStation)
        {
            FindElementWithWaiter(INPUT_DEPARTURE_STATION).SendKeys(nameStation);
        }
        public void InputDestinationStation(string nameStation)
        {
            FindElementWithWaiter(INPUT_DESTINATION_STATION).Click();
            FindElementWithWaiter(INPUT_DESTINATION_STATION).SendKeys(nameStation);
            FindElementWithWaiter(INPUT_CHOOSE_DESTINATION_STATION + nameStation + " ')]").Click();
        }

        public void ChooseDayCurrentMonth(string day)
        {
            try {FindElementWithWaiter(INPUT_DATE_DEPART + day+"']").Click(); }
            catch (Exception) { }
        }

        public void AddAdultPassenger(int count) 
        {
            while (count > 0) 
            {
                FindElementsWithWaiter(ADD_PASSENGER)[0].Click();
                --count;
            }
        }

        public void AddTeensPassenger(int count)
        {
            while (count > 0)
            {
                FindElementsWithWaiter(ADD_PASSENGER)[1].Click();
                --count;
            }
        }

        public void AddChildrenPassenger(int count)
        {
            while (count > 0)
            {
                FindElementsWithWaiter(ADD_PASSENGER)[2].Click();
                --count;
            }
        }

        public void AddInfantPassenger(int count)
        {
            while (count > 0)
            {
                FindElementsWithWaiter(ADD_PASSENGER)[3].Click();
                --count;
            }
        }

        public void ConfirmSelection() 
        {
            FindElementWithWaiter(CONFIRM_SELECTION).Click();
        }

        public void AgreeWithUsingCookies() 
        {
            FindElementWithWaiter(AGREE_WITH_USING_COOKIES).Click();
        }
    }
}
