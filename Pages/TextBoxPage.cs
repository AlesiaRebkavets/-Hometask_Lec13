using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class TextBoxPage : Browser
    {
        // saving locators of TextBox page
        private const string TextBoxPageUrl = "https://demoqa.com/text-box";
        private static By _textBoxPageHeader = By.XPath("//*[text()='Text Box']");
        private static By _fullNameTextBoxLocator = By.Id("userName");
        private static By _emailTextBoxLocator = By.Id("userEmail");
        private static By _currentAddressTextBoxLocator = By.XPath("//textarea[@id='currentAddress']");
        private static By _permanentAddressTextBoxLocator = By.Id("permanentAddress");
        private static By _submitButtonLocator = By.Id("submit");
        private static By _currentAddressResultLocator = By.XPath("//*[@id='output']//p[@id='currentAddress']");

        public static void OpenTextBoxPage() => Driver().Navigate().GoToUrl(TextBoxPageUrl);
        // method opens TextBox page
        
        public static string GetTextBoxPageHeader() => Driver().FindElement(_textBoxPageHeader).Text;  
        // returns text of TextBox page header

        public static void EnterFullName(string fullName) => Driver().FindElement(_fullNameTextBoxLocator).SendKeys(fullName);
        // enters string data to Full Name field

        public static void EnterEmail(string email) => Driver().FindElement(_emailTextBoxLocator).SendKeys(email);
        // enters string data to Email field

        public static void EnterCurrentAddress(string currentAddress) => Driver().FindElement(_currentAddressTextBoxLocator).SendKeys(currentAddress);
        // enters string data to Current Address field
        
        public static void EnterPermanentAddress(string permanentAddress) => Driver().FindElement(_permanentAddressTextBoxLocator).SendKeys(permanentAddress);
        // enters string data to Permanent Address field

        public static void ClickSubmitButton()          
        {
            ScrollIntoViewScript(_submitButtonLocator);
            Driver().FindElement(_submitButtonLocator).Click();
        }
        // clicks Submit button
        
        public static string GetCurrentAddressResultText() => Driver().FindElement(_currentAddressResultLocator).Text;  
        // returns Current Address (that appeared when the form is submitted)
    }
}