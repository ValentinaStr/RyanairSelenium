using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using Ryanair.Flight;

namespace Ryanair
{
    public abstract class BasePage
    {
        DriverActions _driverActions;
        public BasePage()
        {
            _driverActions = DriverActions.GetDriverActions();
        }

        protected void GoToUrl(string url)
        {
            _driverActions._driver.Url = url;
            _driverActions._driver.Manage().Window.Maximize();
        }

        protected void ScrollToElementAndClick(string xPath)
        {
            _driverActions._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
            _driverActions._action.MoveToElement(_driverActions._driver.FindElement(By.XPath(xPath)));
            _driverActions._action.Perform();
            _driverActions._driver.FindElement(By.XPath(xPath)).Click();
        }
        protected void ScrollToElement(string xPath)
        {
            _driverActions._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
            _driverActions._action.MoveToElement(_driverActions._driver.FindElement(By.XPath(xPath)));
            _driverActions._action.Perform();
        }

        protected IWebElement FindElementWithWaiter(string xpath)
        {
            return _driverActions._wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }

        protected ReadOnlyCollection<IWebElement> FindElementsWithWaiter(string xpath)
        {
            return _driverActions._wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath(xpath)));
        }

        /*public void Log(DataFlight dataFlight)
        {
            _driverActions._loggerServiceXML.WriteLogAsyncXML(dataFlight );
        }

        public void Log(string data)
        {
            _driverActions._loggerServiceTXT.WriteLogAsyncTXT(data);
        }*/

        public void DriverClose()
        {
            _driverActions._driver.Close();
        }
    }
}
