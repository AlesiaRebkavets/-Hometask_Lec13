using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class ButtonsTest: BaseTest
    {
        [Test]
        public void PerformButtonDoubleClick()  // performing double click on the appropriate button
        {                                       // and verifying the message displayed
            ButtonsPage.OpenButtonsPage();
            ButtonsPage.PerformButtonDoubleClick();
            Assert.IsTrue(ButtonsPage.IsDoubleClickMessageDisplayed());   // verifying that message appeared after double click
            Assert.IsTrue(ButtonsPage.GetDoubleClickMessage().Equals("You have done a double click"));  // verifying that the message is correct
        }
        
        [Test]
        public void PerformRightButtonClick()  // performing right click on the appropriate button
        {                                       // and verifying the message displayed
            ButtonsPage.OpenButtonsPage();
            ButtonsPage.PerformRightClickOnTheButton();
            Assert.IsTrue(ButtonsPage.IsRightClickMessageDisplayed());   // verifying that message appeared after right click
            Assert.IsTrue(ButtonsPage.GetRightClickMessage().Equals("You have done a right click"));  // verifying that message appeared after right click is correct
        }
        
        [Test]
        public void PerformButtonClick()  // performing click on the appropriate button
        {                                       // and verifying the message displayed
            ButtonsPage.OpenButtonsPage();
            ButtonsPage.PerformClickOnTheButton();
            Assert.IsTrue(ButtonsPage.IsClickMessageDisplayed());   // verifying that message appeared after button click
            Assert.IsTrue(ButtonsPage.GetClickMessage().Equals("You have done a dynamic click"));  // verifying that message appeared after button click is correct                 
        }
    }
}