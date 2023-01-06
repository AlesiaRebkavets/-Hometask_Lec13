using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Hometask
{
    public class Browser
    {
        private static IWebDriver driver;
        private static IJavaScriptExecutor _javascriptExecutor;
        private static Actions _driverActions;

        public static IWebDriver Driver()                    // initialisation of webDriver, driverAction and javascriptExecutor
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                _javascriptExecutor = (IJavaScriptExecutor)Driver();
                _driverActions = new Actions(Driver());
            }

            return driver;
        }

        public static void Maximize()                       // maximizing of browser window
        {
            Driver().Manage().Window.Maximize();
        }

        public static void Quit()                          // closes all browser tabs
        {
            Driver().Quit();
        }

        public static void SetImplicitlyWait()                          // ImplicitlyWait Timeout is 20 sec
        {
            Driver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public static void ScrollIntoViewScript(By locator)             // ScrollIntoView js script
        {
            _javascriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", Driver().FindElement(locator));
        }

        public static Actions DriverActions => _driverActions;          // method returns _driverActions
    }
}