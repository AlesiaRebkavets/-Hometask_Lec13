using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Hometask
{
    public class Browser
    {
        private static IWebDriver _driver;
        private static IJavaScriptExecutor _javascriptExecutor;
        private static Actions _driverActions;

        public static IWebDriver Driver()                    
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
                _javascriptExecutor = (IJavaScriptExecutor)Driver();
                _driverActions = new Actions(Driver());
            }

            return _driver;
        }
        // initialisation of webDriver, driverAction and javascriptExecutor

        public static void Maximize() => Driver().Manage().Window.Maximize();
        // maximizing of browser window

        public static void Quit()                          
        {
            Driver().Quit();
            _driver = null;
        }
        // closes all browser tabs

        public static void SetImplicitlyWait() => Driver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        // ImplicitlyWait Timeout is 20 sec
        
        public static void ScrollIntoViewScript(By locator) => _javascriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", Driver().FindElement(locator));       
        // ScrollIntoView js script

        public static Actions DriverActions => _driverActions;          
        // method returns _driverActions
    }
}