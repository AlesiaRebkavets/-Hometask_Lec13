using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class LinksPage: BasePage
    {
        // saving locators of Links page
        private BaseElement _homeLink = new BaseElement(By.Id("simpleLink"));
        private BaseElement _homeijmOALink = new BaseElement(By.Id("dynamicLink"));
        private BaseElement _createdLink = new BaseElement(By.Id("created"));
        private BaseElement _toolsQaImage = new BaseElement(By.XPath("//img[@src='/images/Toolsqa.jpg']"));
        private BaseElement _responseStatusCode = new BaseElement(By.XPath("//*[@id='linkResponse']/*[text()='201']"));
        private BaseElement _responseStatusText = new BaseElement(By.XPath("//*[@id='linkResponse']/*[text()='Created']"));

        // passing URL to the constructor
        public LinksPage(): base("https://demoqa.com/links"){}

        // method clicks "Home" link
        public void ClickHomeLink()
        {
            _homeLink.ScrollIntoViewScript();
            _homeLink.Click();
        } 

        // method clicks "HomeijmOA" link
        public void ClickHomeijmOALink()
        {
            _homeLink.ScrollIntoViewScript();
            _homeijmOALink.Click();
        }

        // method clicks "Created" link
        public void ClickCreatedLink()
        {
            _createdLink.ScrollIntoViewScript();
            _createdLink.Click();
        }

        // method returns 'true' if Home page is opened
        public bool IsHomePageOpened => _toolsQaImage.Displayed;

        // method returns text of displayed status code
        public string GetTextOfResponseStatusCode => _responseStatusCode.Text;

        // method returns text of displayed response status
        public string GetTextOfResponseStatusText => _responseStatusText.Text;
    }
}