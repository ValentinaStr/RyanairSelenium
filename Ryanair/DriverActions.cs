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
        
        private DriverActions()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAITTIME));
            _action = new Actions(_driver);
            
        }

        public static DriverActions GetDriverActions() 
        {
            _instance ??= new DriverActions();
            return _instance;
        }
    }
}
