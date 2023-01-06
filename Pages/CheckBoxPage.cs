using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class CheckBoxPage: BasePage
    {
        // saving locators of CheckBox page
        private static By _homeCollapseButtonLocator = By.XPath("//label[@for=\"tree-node-home\"]/../button");
        private static By _documentsCollapseButtonLocator = By.XPath("//label[@for=\"tree-node-documents\"]/../button");
        private static By _officeCollapseButtonLocator = By.XPath("//label[@for=\"tree-node-office\"]/../button");
        private static By _privateCheckboxLocator = By.XPath("//label[@for=\"tree-node-private\"]/span[1]");
        private static By _classifiedCheckboxLocator = By.XPath("//label[@for=\"tree-node-classified\"]/span");
        private static By _youHaveSelectedLabelTextPrivateOptionLocator = By.XPath("//span[text()=\"private\"]");
        private static By _youHaveSelectedLabelTextClassifiedOptionLocator = By.XPath("//span[text()='classified']");

        public static void OpenCheckBoxPage()                               // method opens CheckBox page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenCheckBoxElementPage();
        }

        public static void ClickHomeCollapseButton()                         // method clicks Home Collapse button 
        {
            Driver().FindElement(_homeCollapseButtonLocator).Click();
        }
        
        public static void ClickDocumentsCollapseButton()                    // method clicks Documents Collapse button 
        {
            Driver().FindElement(_documentsCollapseButtonLocator).Click();
        }
        
        public static void ClickOfficeCollapseButton()                       // method clicks Office Collapse button 
        {
            Driver().FindElement(_officeCollapseButtonLocator).Click();
        }
        
        public static void ClickPrivateCheckbox()                            // method checks Private Checkbox 
        {
            Driver().FindElement(_privateCheckboxLocator).Click();
        }
        
        public static void ClickClassifiedCheckbox()                        // method checks Classified Checkbox 
        {
            Driver().FindElement(_classifiedCheckboxLocator).Click();
        }
        
        public static string GetDisplayedFinalText()                       // method returns displayed final text
        {
            return $"{Driver().FindElement(_youHaveSelectedLabelTextPrivateOptionLocator).Text} {Driver().FindElement(_youHaveSelectedLabelTextClassifiedOptionLocator).Text}";
        }
    }
}