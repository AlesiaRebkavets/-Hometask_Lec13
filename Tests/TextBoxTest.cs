using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class TextBoxTest: BaseTest
    {
        [Test]
        // verifying that TextBox Element page is opened successfully
        public void TextBoxElementPageIsOpened()    
        {
            TextBoxPage.OpenTextBoxPage();
            Assert.IsTrue(TextBoxPage.GetTextBoxPageHeader().Equals("Text Box"));
        }

        [Test]
        // verifying that form is filled and submitted successfully
        public void IsFormFilledAndSubmitted()     
        {
            TextBoxPage.OpenTextBoxPage();
            TextBoxPage.EnterFullName("Vasya");
            TextBoxPage.EnterEmail("iamvasya@gmail.com");
            TextBoxPage.EnterCurrentAddress("ulica Pushkina, dom Kolotushkina");
            TextBoxPage.EnterPermanentAddress("Konstitucijos str.");
            TextBoxPage.ClickSubmitButton();
            Assert.AreEqual("Current Address :ulica Pushkina, dom Kolotushkina", TextBoxPage.GetCurrentAddressResultText());
        }
    }
}