using System.Security.Policy;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class LinksPage: BasePage
    {
        // saving locators of Links page
        private static By _homeLinkLocator = By.Id("simpleLink");
        private static By _homeijmOALinkLocator = By.Id("dynamicLink");
        private static By _createdLinkLocator = By.Id("created");
        private static By _toolsQaImageLocator = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        private static By _responseStatusCodeLocator = By.XPath("//p[@id = 'linkResponse']/b[1]");
        private static By _responseStatusTextLocator = By.XPath("//p[@id = 'linkResponse']/b[2]");




        public static void OpenLinksPage()               // method opens Links page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenLinksElementPage();
        }

        public static void ClickHomeLink()                           // method clicks "Home" link
        {
            Driver().FindElement(_homeLinkLocator).Click();
        }

        public static void ClickHomeijmOALink()                      // method clicks "HomeijmOA" link
        {
            Driver().FindElement(_homeijmOALinkLocator).Click();
        }

        public static void ClickCreatedLink()                        // method clicks "Created" link
        {
            Driver().FindElement(_createdLinkLocator).Click();
        }

        public static bool IsHomePageOpened()                        // method returns 'true' if Home page is opened
        {
            return Driver().FindElement(_toolsQaImageLocator).Displayed;
        }

        public static string GetTextOfResponseStatusCode()           // method returns text of displayed status code
        {
            return Driver().FindElement(_responseStatusCodeLocator).Text;
        }
        
        public static string GetTextOfResponseStatusText()           // method returns text of displayed response status
        {
            return Driver().FindElement(_responseStatusTextLocator).Text;
        }
        
    }
}