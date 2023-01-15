using System;
using System.Threading;
using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class ButtonsPage: BasePage
    {
        // saving locators of Buttons page
        private BaseElement _doubleClickButton = new BaseElement(By.Id("doubleClickBtn"));
        private BaseElement _rightClickButton = new BaseElement(By.Id("rightClickBtn")); 
        private BaseElement _clickButton = new BaseElement(By.XPath("//*[text()='Click Me']"));
        private BaseElement _doubleClickMessage = new BaseElement(By.Id("doubleClickMessage"));
        private BaseElement _rightClickMessage = new BaseElement(By.Id("rightClickMessage"));
        private BaseElement _clickMessage = new BaseElement(By.Id("dynamicClickMessage"));

        // passing URL to the constructor
        public ButtonsPage(): base("https://demoqa.com/buttons"){}

        // performing double click
        public void PerformButtonDoubleClick()         
        {
            Thread.Sleep(1000);
            _doubleClickButton.ScrollIntoViewScript();
            _doubleClickButton.DoubleClick();
        }

        // performing right click
        public void PerformRightClickOnTheButton()     
        {
            Thread.Sleep(1000);
            _rightClickButton.ScrollIntoViewScript();
            _rightClickButton.ContextClick();
        }

        // performing button click
        public void PerformClickOnTheButton()          
        {
            Thread.Sleep(1000);
            _clickButton.ScrollIntoViewScript();
            _clickButton.Click();
        }

        // method returns text of the message displayed after successful double click
        public string GetDoubleClickMessage => _doubleClickMessage.Text;

        // method returns text of the message displayed after successful right click
        public string GetRightClickMessage => _rightClickMessage.Text;

        // method returns text of the message displayed after successful click
        public string GetClickMessage => _clickMessage.Text;

        // method returns 'true' if DoubleClick Message is displayed
        public bool IsDoubleClickMessageDisplayed => _doubleClickMessage.Displayed;

        // method returns 'true' if RightClick Message is displayed 
        public bool IsRightClickMessageDisplayed => _rightClickMessage.Displayed;

        // method returns 'true' if Click Message is displayed  
        public bool IsClickMessageDisplayed => _clickMessage.Displayed;
    }
}