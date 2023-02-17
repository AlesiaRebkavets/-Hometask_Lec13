using Hometask.Pages;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class WebTablesTest: BaseTest
    {
        private WebTablesPage _webTablesPage = new WebTablesPage();
        
        // verifying that new row is added to a WebTable
        [Test]
        public void IsRegistrationFormModalDisplayed()          
        {
            _webTablesPage.OpenPage();
            _webTablesPage.ClickAddButton();
            Assert.IsTrue(_webTablesPage.IsRegistrationFormModalLabelDisplayed);
        }

        // verifying that new row is added to a WebTable and correct data was entered
        [Test]
        public void AddRowToAWebTable()
        {
            _webTablesPage.OpenPage();
            _webTablesPage.ClickAddButton();
            _webTablesPage.SetFirstNameValue("Walter");
            _webTablesPage.SetLastNameValue("White");
            _webTablesPage.SetEmailValue("heisenberg@gmail.com");
            _webTablesPage.SetAgeValue("51");
            _webTablesPage.SetSalaryValue("11000000");
            _webTablesPage.SetDepartmentValue("Chemistry Department");
            _webTablesPage.ClickSubmitButton();
            Assert.IsTrue(_webTablesPage.GetFirstNameTableColumnValue.Equals("Walter"));
            Assert.IsTrue(_webTablesPage.GetLastNameTableColumnValue.Equals("White"));
            Assert.IsTrue(_webTablesPage.GetEmailTableColumnValue.Equals("heisenberg@gmail.com"));
            Assert.IsTrue(_webTablesPage.GetAgeTableColumnValue.Equals("51"));
            Assert.IsTrue(_webTablesPage.GetSalaryTableColumnValue.Equals("11000000"));
            Assert.IsTrue(_webTablesPage.GetDepartmentTableColumnValue.Equals("Chemistry Department"));
        }
    }
}