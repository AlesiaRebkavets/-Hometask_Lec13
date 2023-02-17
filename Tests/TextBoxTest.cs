using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class TextBoxTest: BaseTest
    {
        private TextBoxPage _textBoxPage = new TextBoxPage();
        
        // verifying that TextBox Element page is opened successfully
        [Test]
        public void TextBoxElementPageIsOpened()    
        {
            _textBoxPage.OpenPage();
            Assert.IsTrue(_textBoxPage.GetTextBoxPageHeader.Equals("Text Box"));
        }

        // verifying that form is filled and submitted successfully
        [Test]
        public void IsFormFilledAndSubmitted()     
        {
            _textBoxPage.OpenPage();
            _textBoxPage.EnterFullName("Vasya");
            _textBoxPage.EnterEmail("iamvasya@gmail.com");
            _textBoxPage.EnterCurrentAddress("ulica Pushkina, dom Kolotushkina");
            _textBoxPage.EnterPermanentAddress("Konstitucijos str.");
            _textBoxPage.ClickSubmitButton();
            Assert.AreEqual("Current Address :ulica Pushkina, dom Kolotushkina", _textBoxPage.GetCurrentAddressResultText);
        }
    }
}