using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class CheckBoxTest: BaseTest
    {
        private CheckBoxPage _checkBoxPage = new CheckBoxPage();
        
        // verifying that CheckBox elements are successfully checked
        [Test]
        public void IsCheckBoxElementSelected()             
        {
            _checkBoxPage.OpenPage();
            _checkBoxPage.ClickHomeCollapseButton();
            _checkBoxPage.ClickDocumentsCollapseButton();
            _checkBoxPage.ClickOfficeCollapseButton();
            _checkBoxPage.ClickPrivateCheckbox();
            _checkBoxPage.ClickClassifiedCheckbox();
            Assert.AreEqual("private classified", _checkBoxPage.GetDisplayedFinalText);
        }
    }
}