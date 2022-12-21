using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Hometask
{
    public class Browser
    {
        private static IWebDriver driver;


        // private IWebDriver DriverIsNull()
        // {
        //     if (driver == null)
        //     { 
        //         driver = new ChromeDriver();
        //     }
        //
        //     return driver;
        // }
        
        public static IWebDriver Driver()
       { 
           if (driver == null)
           { 
               driver = new ChromeDriver();
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
        
    }
}