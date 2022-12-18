using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Hometask.Pages
{
    public class BasePage
    {  protected static IWebDriver _driver;
       protected static WebDriverWait _wait;
       protected const string _baseUrl = "https://demoqa.com/";
       private static By _elementsButtonLocator = By.XPath("//div[@class='category-cards']/div[1]");
       private static By _textBoxMenuItemLocator = By.XPath("//ul[@class='menu-list']/li[1]");
   
       public BasePage(IWebDriver browser) => _driver = browser;
       
        public static void OpenBasePage() => _driver.Navigate().GoToUrl(_baseUrl);

        public static void OpenElementsPage()
        {
            _driver.FindElement(_elementsButtonLocator).Click();
        }

        public static void OpenTextBoxElementPage()
        {
            _driver.FindElement(_textBoxMenuItemLocator).Click();
        }
    }
}