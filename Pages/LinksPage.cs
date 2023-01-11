using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class LinksPage: Browser
    {
        // saving locators of Links page
        private const string LinksPageUrl = "https://demoqa.com/links";
        private static By _homeLinkLocator = By.Id("simpleLink");
        private static By _homeijmOALinkLocator = By.Id("dynamicLink");
        private static By _createdLinkLocator = By.Id("created");
        private static By _toolsQaImageLocator = By.XPath("//img[@src='/images/Toolsqa.jpg']");
        private static By _responseStatusCodeLocator = By.XPath("//*[@id = 'linkResponse']/b[1]");
        private static By _responseStatusTextLocator = By.XPath("//*[@id = 'linkResponse']/b[2]");

        public static void OpenLinksPage() => Driver().Navigate().GoToUrl(LinksPageUrl);
        // method opens Links page

        public static void ClickHomeLink() => Driver().FindElement(_homeLinkLocator).Click();
        // method clicks "Home" link

        public static void ClickHomeijmOALink() => Driver().FindElement(_homeijmOALinkLocator).Click();
        // method clicks "HomeijmOA" link

        public static void ClickCreatedLink() => Driver().FindElement(_createdLinkLocator).Click();
        // method clicks "Created" link

        public static bool IsHomePageOpened() => Driver().FindElement(_toolsQaImageLocator).Displayed;
        // method returns 'true' if Home page is opened

        public static string GetTextOfResponseStatusCode() => Driver().FindElement(_responseStatusCodeLocator).Text;
        // method returns text of displayed status code

        public static string GetTextOfResponseStatusText() => Driver().FindElement(_responseStatusTextLocator).Text;
        // method returns text of displayed response status
    }
}