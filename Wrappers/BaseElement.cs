using Hometask;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Hometask_Lec13.Wrappers
{
    public class BaseElement
    {
        protected IWebDriver Driver => Browser.Driver();
        private IJavaScriptExecutor JavaScriptExecutor => Browser.JavaScriptExecutor();
        protected Actions DriverActions = Browser.DriverActions();
        private By _by;
        private IWebElement _webElement;

        // passing locator to the constructor
        public BaseElement(By locator)
        {
            _by = locator;
        }

        public IWebElement Element => Driver.FindElement(_by);
        
        // ScrollIntoView js script
        public void ScrollIntoViewScript() => JavaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView()", Element);

        // method performs Double Click
        public void DoubleClick() => DriverActions.DoubleClick(Element).Build().Perform();

        // method performs Context Click
        public void ContextClick() => DriverActions.ContextClick(Element).Build().Perform();
        
        // method performs Click
        public void Click() => DriverActions.Click(Element).Build().Perform();

        // method returns the element's text
        public string Text => Element.Text;

        // method return 'true' if the element is displayed
        public bool Displayed => Element.Displayed;
        
        // method passes value to the element (input field)
        public void SendKeys(string fullName) => Element.SendKeys(fullName);
    }
}