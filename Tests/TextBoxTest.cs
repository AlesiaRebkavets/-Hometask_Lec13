using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class TextBoxTest: BaseTest
    {
        [Test]
        public void TextBoxElementPageIsOpened()    // todo: 
        {
            TextBoxPage.OpenTextBoxPage();
            Assert.IsTrue(TextBoxPage.GetTextBoxPageHeader().Equals("Text Box"));
        }

        [Test]
        public void IsFormFilledAndSubmitted()    
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