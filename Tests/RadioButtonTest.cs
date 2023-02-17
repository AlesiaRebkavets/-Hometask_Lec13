using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class RadioButtonTest: BaseTest
    {
        private RadioButtonPage _radioButtonPage = new RadioButtonPage();
        
        // verifying that YouHaveSelected label is displayed when any Radio Button is checked
        [Test]
        public void IsYouHaveSelectedLabelDisplayed()                         
        {                                                                    
            _radioButtonPage.OpenPage();
            _radioButtonPage.ClickImpressiveRadioButton();
            Assert.IsTrue(_radioButtonPage.IsYouHaveSelectedLabelDisplayed);
        }
        
        // verifying that Radio Button was successfully checked
        [Test]
        public void SelectRadioButton()                                        
        {
            _radioButtonPage.OpenPage();
            _radioButtonPage.ClickImpressiveRadioButton();
            Assert.AreEqual("Impressive", _radioButtonPage.GetYouHaveSelectedLabelText);
        }
    }
}