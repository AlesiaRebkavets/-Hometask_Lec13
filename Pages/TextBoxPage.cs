using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class TextBoxPage : BasePage
    {
        private static By _textBoxPageHeader = By.XPath("//div[text()='Text Box']");
        private static By _fullNameTextBoxLocator = By.Id("userName");
        private static By _emailTextBoxLocator = By.Id("userEmail");
        private static By _currentAddressTextBoxLocator = By.Id("currentAddress");
        private static By _permanentAddressTextBoxLocator = By.Id("permanentAddress");
        private static By _submitButtonLocator = By.Id("submit");
        private static By _currentAddressResultLocator = By.XPath("//p[@id='currentAddress']");
        
        public static void OpenTextBoxPage()
        {
            OpenBasePage();
            OpenElementsPage();
            OpenTextBoxElementPage();
        }
        public static string GetTextBoxPageHeader() => Driver().FindElement(_textBoxPageHeader).Text;

        public static void EnterFullName(string fullName)
        {
            // SetJavaScriptExecutor(_fullNameTextBoxLocator);
            // DriverActions.SendKeys(Keys.PageDown).Perform();
            
            Driver().FindElement(_fullNameTextBoxLocator).SendKeys(fullName);
        }
        
        public static void EnterEmail(string email)
        {
            Driver().FindElement(_emailTextBoxLocator).SendKeys(email);
        }
        
        public static void EnterCurrentAddress(string currentAddress)
        {
            Driver().FindElement(_currentAddressTextBoxLocator).SendKeys(currentAddress);
        }
        public static void EnterPermanentAddress(string permanentAddress)
        {
            Driver().FindElement(_permanentAddressTextBoxLocator).SendKeys(permanentAddress);
        }
        public static void clickSubmitButton()
        {
           // DriverActions.SendKeys(Keys.PageDown).Perform();
            ScrollIntoViewScript(_submitButtonLocator);
            Driver().FindElement(_submitButtonLocator).Click();
            //clickScript(_submitButtonLocator);
        }
        
        public static string GetCurrentAddressResultText() => Driver().FindElement(_currentAddressResultLocator).Text;
    }
}