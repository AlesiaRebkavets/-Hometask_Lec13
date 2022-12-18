using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class TextBoxTest: BaseTest
    {
        // [Test]
        // public void FirstTest()
        // {
        //     TextBoxPage testBoxPage = new TextBoxPage(_driver);
        // }

        [Test]
        public void TextBoxElementPageIsOpened()
        {
            BasePage.OpenBasePage();
            BasePage.OpenElementsPage();
            BasePage.OpenTextBoxElementPage();
            Assert.IsTrue(TextBoxPage.GetTextBoxPageHeader().Equals("Text Box"));
        }




    }
}