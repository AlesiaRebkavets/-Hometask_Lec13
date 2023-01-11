using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class CheckBoxPage: Browser
    {
        // saving locators of CheckBox page
        private const string CheckBoxPageUrl = "https://demoqa.com/checkbox";
        private static By _homeCollapseButtonLocator = By.XPath("//button[..//@for='tree-node-home']");
        private static By _documentsCollapseButtonLocator = By.XPath("//label[@for='tree-node-documents']/../button");
        private static By _officeCollapseButtonLocator = By.XPath("//label[@for='tree-node-office']/../button");
        private static By _privateCheckboxLocator = By.XPath("//label[@for='tree-node-private']/span[1]");
        private static By _classifiedCheckboxLocator = By.XPath("//label[@for='tree-node-classified']/span");
        private static By _youHaveSelectedLabelTextPrivateOptionLocator = By.XPath("//span[text()='private']");
        private static By _youHaveSelectedLabelTextClassifiedOptionLocator = By.XPath("//span[text()='classified']");

        public static void OpenCheckBoxPage() => Driver().Navigate().GoToUrl(CheckBoxPageUrl);
        // method opens CheckBox page

        public static void ClickHomeCollapseButton() => Driver().FindElement(_homeCollapseButtonLocator).Click();
        // method clicks Home Collapse button 

        public static void ClickDocumentsCollapseButton() => Driver().FindElement(_documentsCollapseButtonLocator).Click();
        // method clicks Documents Collapse button 

        public static void ClickOfficeCollapseButton() => Driver().FindElement(_officeCollapseButtonLocator).Click();
        // method clicks Office Collapse button 

        public static void ClickPrivateCheckbox() => Driver().FindElement(_privateCheckboxLocator).Click();
        // method checks Private Checkbox 

        public static void ClickClassifiedCheckbox() => Driver().FindElement(_classifiedCheckboxLocator).Click();
        // method checks Classified Checkbox 

        public static string GetDisplayedFinalText() => $"{Driver().FindElement(_youHaveSelectedLabelTextPrivateOptionLocator).Text} {Driver().FindElement(_youHaveSelectedLabelTextClassifiedOptionLocator).Text}"; 
        // method returns displayed final text
    }
}