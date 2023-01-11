using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class LinksTest: BaseTest
    {
        [Test]
        // performing click on 'Home' link
        public void FollowingHomeLink()                   
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickHomeLink();
            Assert.IsTrue(LinksPage.IsHomePageOpened());
        }
        
        [Test]
        // performing click on 'HomeijmOA' link
        public void FollowingHomeijmOALink()              
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickHomeijmOALink();
            Assert.IsTrue(LinksPage.IsHomePageOpened());
            
        }
        
        [Test]
        // performing click on 'Created' link
        public void FollowingCreatedLink()                
        {
            LinksPage.OpenLinksPage();
            LinksPage.ClickCreatedLink();
            Assert.AreEqual("201", LinksPage.GetTextOfResponseStatusCode());
            Assert.AreEqual("Created", LinksPage.GetTextOfResponseStatusText());
        }
    }
}