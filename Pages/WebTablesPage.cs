using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class WebTablesPage : BasePage
    {
        // saving locators of WebTables page
        private BaseElement _addButton = new BaseElement(By.Id("addNewRecordButton"));
        private BaseElement _registrationFormModalLabel = new BaseElement(By.Id("registration-form-modal"));
        private BaseElement _firstNameTextBox = new BaseElement(By.Id("firstName"));
        private BaseElement _lastNameTextBox = new BaseElement(By.Id("lastName"));
        private BaseElement _emailTextBox = new BaseElement(By.Id("userEmail"));
        private BaseElement _ageTextBox = new BaseElement(By.Id("age"));
        private BaseElement _salaryTextBox = new BaseElement(By.Id("salary"));
        private BaseElement _departmentTextBox = new BaseElement(By.Id("department"));
        private BaseElement _submitButton = new BaseElement(By.Id("submit"));
       
        private BaseElement _firstNameTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][1]"));
        
        private BaseElement _lastNameTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][2]"));

        private BaseElement _ageTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][3]"));

        private BaseElement _emailTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][4]"));

        private BaseElement _salaryTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][5]"));

        private BaseElement _departmentTableColumn =
            new BaseElement(By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][6]"));

        // passing URL to the constructor
        public WebTablesPage(): base("https://demoqa.com/webtables"){}

        // method clicks Add Button
        public void ClickAddButton() => _addButton.Click();

        // returns "true" if Registration Form Modal is opened (Registration Form Modal Label is displayed)
        public bool IsRegistrationFormModalLabelDisplayed => _registrationFormModalLabel.Displayed;

        // entering value to First Name field
        public void SetFirstNameValue(string firstName) => _firstNameTextBox.SendKeys(firstName);

        // entering value to Last Name field
        public void SetLastNameValue(string lastName) => _lastNameTextBox.SendKeys(lastName);

        // entering value to Email field
        public void SetEmailValue(string email) => _emailTextBox.SendKeys(email);

        // entering value to Age field
        public void SetAgeValue(string age) => _ageTextBox.SendKeys(age);

        // entering value to Salary field
        public void SetSalaryValue(string salary) => _salaryTextBox.SendKeys(salary);

        // entering value to Department field
        public void SetDepartmentValue(string department) => _departmentTextBox.SendKeys(department);

        // method clicks Submit Button
        public void ClickSubmitButton() => _submitButton.Click();

        // method returns value of First Name table column
        public string GetFirstNameTableColumnValue => _firstNameTableColumn.Text;

        // method returns value of Last Name table column
        public string GetLastNameTableColumnValue => _lastNameTableColumn.Text;

        // method returns value of Age table column
        public string GetAgeTableColumnValue => _ageTableColumn.Text;
        
        // method returns value of Email table column
        public string GetEmailTableColumnValue => _emailTableColumn.Text;

        // method returns value of Salary table column
        public string GetSalaryTableColumnValue => _salaryTableColumn.Text;

        // method returns value of Department table column
        public string GetDepartmentTableColumnValue =>  _departmentTableColumn.Text;
    }
}