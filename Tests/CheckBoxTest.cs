using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class CheckBoxTest: BaseTest
    {
        [Test]
        // verifying that CheckBox elements are successfully checked
        public void IsCheckBoxElementSelected()             
        {
            CheckBoxPage.OpenCheckBoxPage();
            CheckBoxPage.ClickHomeCollapseButton();
            CheckBoxPage.ClickDocumentsCollapseButton();
            CheckBoxPage.ClickOfficeCollapseButton();
            CheckBoxPage.ClickPrivateCheckbox();
            CheckBoxPage.ClickClassifiedCheckbox();
            Assert.AreEqual("private classified", CheckBoxPage.GetDisplayedFinalText());
        }
    }
}