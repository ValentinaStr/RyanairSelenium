using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ryanair
{
    internal class DriverActions
    {
        const int WAITTIME = 30;
        static DriverActions? _instance;
        internal IWebDriver _driver;
        internal WebDriverWait _wait;
        internal Actions _action;
        //internal LoggerServiceTXT _loggerServiceTXT;
        //internal LoggerServiceXML<DataFlight> _loggerServiceXML;

        private DriverActions()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAITTIME));
            _action = new Actions(_driver);
            //_loggerServiceTXT = new LoggerServiceTXT();
           // _loggerServiceXML = new LoggerServiceXML<DataFlight>();
        }

        public static DriverActions GetDriverActions() 
        {
            _instance ??= new DriverActions();
            return _instance;
        }
    }
}
