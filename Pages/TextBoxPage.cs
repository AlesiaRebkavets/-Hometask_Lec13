using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class TextBoxPage : BasePage
    {
        // saving locators of TextBox page
        private static By _textBoxPageHeader = By.XPath("//div[text()='Text Box']");
        private static By _fullNameTextBoxLocator = By.Id("userName");
        private static By _emailTextBoxLocator = By.Id("userEmail");
        private static By _currentAddressTextBoxLocator = By.XPath("//textarea[@id='currentAddress']");
        private static By _permanentAddressTextBoxLocator = By.Id("permanentAddress");
        private static By _submitButtonLocator = By.Id("submit");
        private static By _currentAddressResultLocator = By.XPath("//div[@id='output']//p[@id='currentAddress']");
        
        public static void OpenTextBoxPage()         // method opens TextBox page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenTextBoxElementPage();
        }
        public static string GetTextBoxPageHeader() => Driver().FindElement(_textBoxPageHeader).Text;  // returns text of TextBox page header

        public static void EnterFullName(string fullName)          // enters string data to Full Name field
        {
            Driver().FindElement(_fullNameTextBoxLocator).SendKeys(fullName);
        }
        
        public static void EnterEmail(string email)                // enters string data to Email field
        {
            Driver().FindElement(_emailTextBoxLocator).SendKeys(email);
        }
        
        public static void EnterCurrentAddress(string currentAddress)  // enters string data to Current Address field
        {
            Driver().FindElement(_currentAddressTextBoxLocator).SendKeys(currentAddress);
        }
        public static void EnterPermanentAddress(string permanentAddress)  // enters string data to Permanent Address field
        {
            Driver().FindElement(_permanentAddressTextBoxLocator).SendKeys(permanentAddress);
        }
        public static void clickSubmitButton()          // clicks Submit button
        {
            ScrollIntoViewScript(_submitButtonLocator);
            Driver().FindElement(_submitButtonLocator).Click();
        }
        
        public static string GetCurrentAddressResultText() => Driver().FindElement(_currentAddressResultLocator).Text;  
        // returns Current Address (that appeared when the form is submitted)
    }
}