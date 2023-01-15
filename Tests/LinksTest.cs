using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class LinksTest: BaseTest
    {
        private LinksPage _linksPage = new LinksPage();
        
        // performing click on 'Home' link
        [Test]
        public void FollowingHomeLink()                   
        {
            _linksPage.OpenPage();
            _linksPage.ClickHomeLink();
            Assert.IsTrue(_linksPage.IsHomePageOpened);
        }
        
        // performing click on 'HomeijmOA' link
        [Test]
        public void FollowingHomeijmOALink()              
        {
            _linksPage.OpenPage();
            _linksPage.ClickHomeijmOALink();
            Assert.IsTrue(_linksPage.IsHomePageOpened);
        }
        
        // performing click on 'Created' link
        [Test]
        public void FollowingCreatedLink()                
        {
            _linksPage.OpenPage();
            _linksPage.ClickCreatedLink();
            Assert.AreEqual("201", _linksPage.GetTextOfResponseStatusCode);
            Assert.AreEqual("Created", _linksPage.GetTextOfResponseStatusText);
        }
    }
}