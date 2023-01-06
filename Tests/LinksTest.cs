using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class LinksTest: BaseTest
    {
        [Test]
        public void FollowingHomeLink()                   // performing click on 'Home' link
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickHomeLink();
            Assert.IsTrue(LinksPage.IsHomePageOpened());
        }
        
        [Test]
        public void FollowingHomeijmOALink()              // performing click on 'HomeijmOA' link
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickHomeijmOALink();
            Assert.IsTrue(LinksPage.IsHomePageOpened());
            
        }
        
        [Test]
        public void FollowingCreatedLink()                // performing click on 'Created' link
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickCreatedLink();
            Assert.AreEqual("201", LinksPage.GetTextOfResponseStatusCode());
            Assert.AreEqual("Created", LinksPage.GetTextOfResponseStatusText());
        }

        
        
        
        
        
        
    }
}