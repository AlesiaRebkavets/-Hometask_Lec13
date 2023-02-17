using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Hometask.Pages
{
    public class BasePage
    {
        private readonly string _url;
        protected IWebDriver Driver => Browser.Driver();
        private IJavaScriptExecutor JavaScriptExecutor => Browser.JavaScriptExecutor();
        protected Actions DriverActions = Browser.DriverActions();

        protected BasePage(string url) { _url = url; }
        
        // method opens Buttons page
        public void OpenPage() => Driver.Navigate().GoToUrl(_url);
    }
}