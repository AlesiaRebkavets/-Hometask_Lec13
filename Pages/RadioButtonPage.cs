using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class RadioButtonPage: Browser
    {
        // saving locators of RadioButton page
        private const string RadioButtonPageUrl = "https://demoqa.com/radio-button";
        private static By _impressiveRadioButtonLocator = By.XPath("//label[text()='Impressive']");
        private static By _youHaveSelectedLabelLocator = By.XPath("//*[contains(text(), 'You have selected')]/span");

        public static void OpenRadioButtonPage() => Driver().Navigate().GoToUrl(RadioButtonPageUrl);
        // method opens RadioButton page

        public static void ClickImpressiveRadioButton() => Driver().FindElement(_impressiveRadioButtonLocator).Click();
        // method clicks Impressive Radio Button

        public static bool IsYouHaveSelectedLabelDisplayed() => Driver().FindElement(_youHaveSelectedLabelLocator).Displayed;
        // method returns 'true' if YouHaveSelectedLabel is displayed

        public static string GetYouHaveSelectedLabelText() => Driver().FindElement(_youHaveSelectedLabelLocator).Text;
        // method returns text of YouHaveSelected label
    }
}