using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class TextBoxTest: BaseTest
    {
        [Test]
        public void TextBoxElementPageIsOpened()    // verifying that TextBox Element page is opened successfully
        {
            TextBoxPage.OpenTextBoxPage();
            Assert.IsTrue(TextBoxPage.GetTextBoxPageHeader().Equals("Text Box"));
        }

        [Test]
        public void IsFormFilledAndSubmitted()     // verifying that form is filled and submitted successfully
        {
            TextBoxPage.OpenTextBoxPage();
            TextBoxPage.EnterFullName("Vasya");
            TextBoxPage.EnterEmail("iamvasya@gmail.com");
            TextBoxPage.EnterCurrentAddress("ulica Pushkina, dom Kolotushkina");
            TextBoxPage.EnterPermanentAddress("Konstitucijos str.");
            TextBoxPage.clickSubmitButton();
            Assert.AreEqual("Current Address :ulica Pushkina, dom Kolotushkina", TextBoxPage.GetCurrentAddressResultText());
        }
        
        
        
        
        
    }
}