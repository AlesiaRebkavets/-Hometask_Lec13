using System.Threading;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class ButtonsPage: Browser
    {
        // saving locators of Buttons page
        private const string ButtonsPageUrl = "https://demoqa.com/buttons";
        private static By _doubleClickButtonLocator = By.Id("doubleClickBtn");
        private static By _rightClickButtonLocator = By.Id("rightClickBtn");
        private static By _clickButtonLocator = By.XPath("//button[text()='Click Me']");
        private static By _doubleClickMessageLocator = By.Id("doubleClickMessage");
        private static By _rightClickMessageLocator = By.Id("rightClickMessage");
        private static By _clickMessageLocator = By.Id("dynamicClickMessage");
        
        public static void OpenButtonsPage() => Driver().Navigate().GoToUrl(ButtonsPageUrl);  
        // method opens Buttons page

        public static void PerformButtonDoubleClick()         
        {
            Thread.Sleep(1000);
            ScrollIntoViewScript(_doubleClickButtonLocator);
            DriverActions.DoubleClick(Driver().FindElement(_doubleClickButtonLocator)).Build().Perform();  
        }
        // performing double click
        
        public static void PerformRightClickOnTheButton()     
        {
            Thread.Sleep(1000);
            ScrollIntoViewScript(_rightClickButtonLocator);
            DriverActions.ContextClick(Driver().FindElement(_rightClickButtonLocator)).Build().Perform(); 
        }
        // performing right click
        
        public static void PerformClickOnTheButton()          
        {
            Thread.Sleep(1000);
            ScrollIntoViewScript(_clickButtonLocator);
            DriverActions.Click(Driver().FindElement(_clickButtonLocator)).Build().Perform();
        }
        // performing button click
        
        public static string GetDoubleClickMessage() => Driver().FindElement(_doubleClickMessageLocator).Text;  
        // method returns text of the message displayed after successful double click
        
        public static string GetRightClickMessage() => Driver().FindElement(_rightClickMessageLocator).Text;
        // method returns text of the message displayed after successful right click
        
        public static string GetClickMessage() => Driver().FindElement(_clickMessageLocator).Text;
        // method returns text of the message displayed after successful click
        
        public static bool IsDoubleClickMessageDisplayed() => Driver().FindElement(_doubleClickMessageLocator).Displayed;
        // method returns 'true' if DoubleClick Message is displayed
        
        public static bool IsRightClickMessageDisplayed() => Driver().FindElement(_rightClickMessageLocator).Displayed;
        // method returns 'true' if RightClick Message is displayed    
        
        public static bool IsClickMessageDisplayed() => Driver().FindElement(_clickMessageLocator).Displayed; 
        // method returns 'true' if Click Message is displayed  
    }
}