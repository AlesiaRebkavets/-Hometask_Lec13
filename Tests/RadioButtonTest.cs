using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class RadioButtonTest: BaseTest
    {
        [Test]
        // verifying that YouHaveSelected label is displayed when any Radio Button is checked
        public void IsYouHaveSelectedLabelDisplayed()                         
        {                                                                    
            RadioButtonPage.OpenRadioButtonPage();
            RadioButtonPage.ClickImpressiveRadioButton();
            Assert.IsTrue(RadioButtonPage.IsYouHaveSelectedLabelDisplayed());
        }
        
        [Test]
        // verifying that Radio Button was successfully checked
        public void SelectRadioButton()                                        
        {
            RadioButtonPage.OpenRadioButtonPage();
            RadioButtonPage.ClickImpressiveRadioButton();
            Assert.AreEqual("Impressive", RadioButtonPage.GetYouHaveSelectedLabelText());
        }
    }
}