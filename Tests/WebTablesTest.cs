using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class WebTablesTest: BaseTest
    {
        [Test]
        public void IsRegistrationFormModalDisplayed()          // verifying that new row is added to a WebTable
        {
            WebTablesPage.OpenWebTablesPage();
            WebTablesPage.ClickAddButton();
            Assert.IsTrue(WebTablesPage.IsRegistrationFormModalLabelDisplayed());
        }

        [Test]
        public void AddRowToAWebTable()                          // verifying that new row is added to a WebTable
        {                                                        // and correct data was entered
            WebTablesPage.OpenWebTablesPage();
            WebTablesPage.ClickAddButton();
            WebTablesPage.SetFirstNameValue("Walter");
            WebTablesPage.SetLastNameValue("White");
            WebTablesPage.SetEmailValue("heisenberg@gmail.com");
            WebTablesPage.SetAgeValue("51");
            WebTablesPage.SetSalaryValue("11000000");
            WebTablesPage.SetDepartmentValue("Chemistry Department");
            WebTablesPage.ClickSubmitButton();
            Assert.IsTrue(WebTablesPage.GetFirstNameTableColumnValue().Equals("Walter"));
            Assert.IsTrue(WebTablesPage.GetLastNameTableColumnValue().Equals("White"));
            Assert.IsTrue(WebTablesPage.GetEmailTableColumnValue().Equals("heisenberg@gmail.com"));
            Assert.IsTrue(WebTablesPage.GetAgeTableColumnValue().Equals("51"));
            Assert.IsTrue(WebTablesPage.GetSalaryTableColumnValue().Equals("11000000"));
            Assert.IsTrue(WebTablesPage.GetDepartmentTableColumnValue().Equals("Chemistry Department"));
        }
    }
}