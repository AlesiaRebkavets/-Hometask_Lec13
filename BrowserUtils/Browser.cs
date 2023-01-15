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

        // initialisation of webDriver
        public static IWebDriver Driver()                    
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
            }
            return _driver;
        }

        // initialisation of javascriptExecutor
        public static IJavaScriptExecutor JavaScriptExecutor() => (IJavaScriptExecutor)Driver();

        // initialisation of driverAction
        public static Actions DriverActions() => new Actions(Driver());

        // maximizing of browser window
        public static void Maximize() => Driver().Manage().Window.Maximize();

        // closes all browser tabs
        public static void Quit()                          
        {
            Driver().Quit();
            _driver = null;
        }

        // ImplicitlyWait Timeout is 20 sec
        public static void SetImplicitlyWait() => Driver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
    }
}