using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Hometask
{
    public class Browser
    {
        private static IWebDriver driver;
        private static IJavaScriptExecutor _javascriptExecutor;
        private static Actions _driverActions;
        
        public static IWebDriver Driver()
       { 
           if (driver == null)
           { 
               driver = new ChromeDriver();
               _javascriptExecutor = (IJavaScriptExecutor)Driver();
               _driverActions = new Actions(Driver());
           }

           return driver;
       }

        public static void Maximize()
        {
            Driver().Manage().Window.Maximize();
        }

        public static void Quit()
        {
            Driver().Quit();
        }

        public static void SetImplicitlyWait()
        {
            Driver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void ScrollIntoViewScript(By locator)
        {
            _javascriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", Driver().FindElement(locator));
        }
        
        public static void clickScript(By locator)
        {
            _javascriptExecutor.ExecuteScript("arguments[0].click()", Driver().FindElement(locator));
        }
        
        
        public static Actions DriverActions => _driverActions;
    }
}