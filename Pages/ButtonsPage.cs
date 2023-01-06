using System.Threading;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class ButtonsPage: BasePage
    {
        // saving locators of Buttons page
        private static By _doubleClickButtonLocator = By.Id("doubleClickBtn");
        private static By _rightClickButtonLocator = By.Id("rightClickBtn");
        private static By _clickButtonLocator = By.XPath("//button[text()=\"Click Me\"]");
        private static By _doubleClickMessageLocator = By.Id("doubleClickMessage");
        private static By _rightClickMessageLocator = By.Id("rightClickMessage");
        private static By _clickMessageLocator = By.Id("dynamicClickMessage");
        
        public static void OpenButtonsPage()                 // method opens Buttons page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenButtonsElementPage();
        }

        public static void PerformButtonDoubleClick()         // performing double click
        {
            Thread.Sleep(20);
            ScrollIntoViewScript(_doubleClickButtonLocator);
            DriverActions.DoubleClick(Driver().FindElement(_doubleClickButtonLocator)).Build().Perform();  
        }
        
        public static void PerformRightClickOnTheButton()     // performing right click
        {
            Thread.Sleep(20);
            ScrollIntoViewScript(_rightClickButtonLocator);
            DriverActions.ContextClick(Driver().FindElement(_rightClickButtonLocator)).Build().Perform(); 
        }
        
        public static void PerformClickOnTheButton()          // performing button click
        {
            Thread.Sleep(20);
            ScrollIntoViewScript(_clickButtonLocator);
            DriverActions.Click(Driver().FindElement(_clickButtonLocator)).Build().Perform();
        }
        
        public static string GetDoubleClickMessage() => Driver().FindElement(_doubleClickMessageLocator).Text;  
        // method returns text of the message displayed after successful double click
        
        public static string GetRightClickMessage() => Driver().FindElement(_rightClickMessageLocator).Text;
        // method returns text of the message displayed after successful right click
        
        public static string GetClickMessage() => Driver().FindElement(_clickMessageLocator).Text;
        // method returns text of the message displayed after successful click
        
        public static bool IsDoubleClickMessageDisplayed()         // method returns 'true' if DoubleClick Message is displayed
        {
            return Driver().FindElement(_doubleClickMessageLocator).Displayed;
        }
        
        public static bool IsRightClickMessageDisplayed()          // method returns 'true' if RightClick Message is displayed        
        {
            return Driver().FindElement(_rightClickMessageLocator).Displayed;
        }
        
        public static bool IsClickMessageDisplayed()               // method returns 'true' if Click Message is displayed  
        {
            return Driver().FindElement(_clickMessageLocator).Displayed;
        }
    }
}