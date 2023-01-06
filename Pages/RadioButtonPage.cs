using System;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class RadioButtonPage: BasePage
    {
        // saving locators of RadioButton page
        private static By _impressiveRadioButtonLocator = By.XPath("//label[text()='Impressive']");
        private static By _youHaveSelectedLabelLocator = By.XPath("//p[contains(text(), 'You have selected')]/span");
        
        public static void OpenRadioButtonPage()                               // method opens RadioButton page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenRadioButtonElementPage();
        }

        public static void ClickImpressiveRadioButton()                        // method clicks Impressive Radio Button
        {
            Driver().FindElement(_impressiveRadioButtonLocator).Click();
        }

        public static bool IsYouHaveSelectedLabelDisplayed()                   // method returns 'true' if YouHaveSelectedLabel is displayed
        {
            return Driver().FindElement(_youHaveSelectedLabelLocator).Displayed;
        }

        public static string GetYouHaveSelectedLabelText()                      // method returns text of YouHaveSelected label
        {
            return Driver().FindElement(_youHaveSelectedLabelLocator).Text;
        } 
    }
}