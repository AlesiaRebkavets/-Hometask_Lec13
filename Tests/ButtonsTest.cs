using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class ButtonsTest: BaseTest
    {
        private ButtonsPage _buttonsPage = new ButtonsPage();
        
        // performing double click on the appropriate button and verifying the message displayed
        [Test]
        public void PerformButtonDoubleClick()
        {
            _buttonsPage.OpenPage();
            _buttonsPage.PerformButtonDoubleClick();
            Assert.IsTrue(_buttonsPage.IsDoubleClickMessageDisplayed);   // verifying that message appeared after double click
            Assert.IsTrue(_buttonsPage.GetDoubleClickMessage.Equals("You have done a double click"));  // verifying that the message is correct
        }
        
        // performing right click on the appropriate button and verifying the message displayed
        [Test]
        public void PerformRightButtonClick()  
        {                                       
            _buttonsPage.OpenPage();
            _buttonsPage.PerformRightClickOnTheButton();
            Assert.IsTrue(_buttonsPage.IsRightClickMessageDisplayed);   // verifying that message appeared after right click
            Assert.IsTrue(_buttonsPage.GetRightClickMessage.Equals("You have done a right click"));  // verifying that message appeared after right click is correct
        }
        
        // performing click on the appropriate button and verifying the message displayed
        [Test]
        public void PerformButtonClick()  
        {                                       
            _buttonsPage.OpenPage();
            _buttonsPage.PerformClickOnTheButton();
            Assert.IsTrue(_buttonsPage.IsClickMessageDisplayed);   // verifying that message appeared after button click
            Assert.IsTrue(_buttonsPage.GetClickMessage.Equals("You have done a dynamic click"));  // verifying that message appeared after button click is correct                 
        }
    }
}