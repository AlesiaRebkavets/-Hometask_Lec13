using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class RadioButtonTest: BaseTest
    {
        [Test]
        public void IsYouHaveSelectedLabelDisplayed()                          // verifying that YouHaveSelected label is displayed
        {                                                                      // when any Radio Button is checked
            RadioButtonPage.OpenRadioButtonPage();
            RadioButtonPage.ClickImpressiveRadioButton();
            Assert.IsTrue(RadioButtonPage.IsYouHaveSelectedLabelDisplayed());
        }
        
        [Test]
        public void SelectRadioButton()                                        // verifying that Radio Button was successfully checked
        {
            RadioButtonPage.OpenRadioButtonPage();
            RadioButtonPage.ClickImpressiveRadioButton();
            Assert.AreEqual("Impressive", RadioButtonPage.GetYouHaveSelectedLabelText());
        }
    }
}