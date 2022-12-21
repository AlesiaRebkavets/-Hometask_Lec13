using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Hometask.Pages
{
    public class BasePage: Browser
    { 
       private const string _baseUrl = "https://demoqa.com/";
       private static By _elementsButtonLocator = By.XPath("//div[@class='category-cards']/div[1]");
       private static By _textBoxMenuItemLocator = By.XPath("//ul[@class='menu-list']/li[1]");
       
        public static void OpenBasePage() => Driver().Navigate().GoToUrl(_baseUrl);

        public static void OpenElementsPage()
        {
            Driver().FindElement(_elementsButtonLocator).Click();
        }

        public static void OpenTextBoxElementPage()
        {
            Driver().FindElement(_textBoxMenuItemLocator).Click();
        }
    }
}