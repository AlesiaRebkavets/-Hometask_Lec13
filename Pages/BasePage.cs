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
       private static By _checkBoxMenuItemLocator = By.XPath("//ul[@class='menu-list']/li[2]");
       private static By _radioButtonMenuItemLocator = By.XPath("//ul[@class='menu-list']//span[text()='Radio Button']");
       private static By _webTablesMenuItemLocator = By.XPath("//ul[@class='menu-list']//span[text()='Web Tables']");
       private static By _buttonsMenuItemLocator = By.XPath("//ul[@class='menu-list']//span[text()='Buttons']");
       private static By _linksMenuItemLocator = By.XPath("//ul[@class='menu-list']//span[text()='Links']");

       public static void OpenBasePage() => Driver().Navigate().GoToUrl(_baseUrl);    // opens base URL

        public static void OpenElementsPage()                        // clicks Elements button and opens Elements page
        {
            Driver().FindElement(_elementsButtonLocator).Click();
        }

        public static void OpenTextBoxElementPage()             // clicks Text Box menu item and opens the appropriate page
        {
            Driver().FindElement(_textBoxMenuItemLocator).Click();
        }

        public static void OpenCheckBoxElementPage()            // clicks Check Box menu item and opens the appropriate page
        {
            Driver().FindElement(_checkBoxMenuItemLocator).Click();
        }

        public static void OpenRadioButtonElementPage()         // clicks Radio Button menu item and opens the appropriate page
        {
            Driver().FindElement(_radioButtonMenuItemLocator).Click();
        }

        public static void OpenWebTablesElementPage()           // clicks Web Tables menu item and opens the appropriate page
        {
            Driver().FindElement(_webTablesMenuItemLocator).Click();
        }
        
        public static void OpenButtonsElementPage()             // clicks Buttons menu item and opens the appropriate page
        {
            ScrollIntoViewScript(_buttonsMenuItemLocator);
            Driver().FindElement(_buttonsMenuItemLocator).Click();
        }
        
        public static void OpenLinksElementPage()               // clicks Links menu item and opens the appropriate page
        {
            ScrollIntoViewScript(_linksMenuItemLocator);
            Driver().FindElement(_linksMenuItemLocator).Click();
        }
    }
}