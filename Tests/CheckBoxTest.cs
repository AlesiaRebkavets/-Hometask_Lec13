using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class CheckBoxTest: BaseTest
    {
        [Test]
        public void IsCheckBoxElementSelected()             // verifying that CheckBox elements are successfully checked
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