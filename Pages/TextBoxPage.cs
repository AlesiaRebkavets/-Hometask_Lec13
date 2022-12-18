using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class TextBoxPage : BasePage
    {
        private static By _textBoxPageHeader = By.XPath("//div[text()='Text Box']");
        private By fullNameTextBoxLocator = By.Id("username");
        private By emailTextBoxLocator = By.Id("userEmail");
        private By currentAddressTextBoxLocator = By.Id("currentAddress");
        private By permanentAddressTextBoxLocator = By.Id("permanentAddress");
        private By submitButtonLocator = By.Id("submit");
        private By currentAddressResultLocator = By.XPath("//p[@id='currentAddress']");
        
        public TextBoxPage(IWebDriver _driver) : base(_driver) { }

        public static string GetTextBoxPageHeader()
        {
            return _driver.FindElement(_textBoxPageHeader).Text;
        }
    }
}