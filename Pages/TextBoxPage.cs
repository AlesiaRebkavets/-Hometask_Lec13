using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class TextBoxPage : BasePage
    {
        // saving locators of TextBox page
        private BaseElement _textBoxPageHeader = new BaseElement(By.XPath("//*[text()='Text Box']"));
        private BaseElement _fullNameTextBox = new BaseElement(By.Id("userName"));
        private BaseElement _emailTextBox = new BaseElement(By.Id("userEmail"));
        private BaseElement _currentAddressTextBox = new BaseElement(By.XPath("//textarea[@id='currentAddress']"));
        private BaseElement _permanentAddressTextBox = new BaseElement(By.Id("permanentAddress"));
        private BaseElement _submitButton = new BaseElement(By.Id("submit"));
        private BaseElement _currentAddressResult =
            new BaseElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
        
        // passing URL to the constructor
        public TextBoxPage(): base("https://demoqa.com/text-box"){}
        
        // returns text of TextBox page header
        public string GetTextBoxPageHeader => _textBoxPageHeader.Text;

        // enters string data to Full Name field
        public void EnterFullName(string fullName) => _fullNameTextBox.SendKeys(fullName);

        // enters string data to Email field
        public void EnterEmail(string email) => _emailTextBox.SendKeys(email);

        // enters string data to Current Address field
        public void EnterCurrentAddress(string currentAddress) => _currentAddressTextBox.SendKeys(currentAddress);

        // enters string data to Permanent Address field
        public void EnterPermanentAddress(string permanentAddress) => _permanentAddressTextBox.SendKeys(permanentAddress);

        // clicks Submit button
        public void ClickSubmitButton()          
        {
            _submitButton.ScrollIntoViewScript();
            _submitButton.Click();
        }

        // returns Current Address (that appeared when the form is submitted)
        public string GetCurrentAddressResultText => _currentAddressResult.Text;
    }
}