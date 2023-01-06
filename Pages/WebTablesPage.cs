using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class WebTablesPage : BasePage
    {
        // saving locators of WebTables page
        private static By _addButtonLocator = By.Id("addNewRecordButton");
        private static By _registrationFormModalLabelLocator = By.Id("registration-form-modal");
        private static By _firstNameTextBoxLocator = By.Id("firstName");
        private static By _lastNameTextBoxLocator = By.Id("lastName");
        private static By _emailTextBoxLocator = By.Id("userEmail");
        private static By _ageTextBoxLocator = By.Id("age");
        private static By _salaryTextBoxLocator = By.Id("salary");
        private static By _departmentTextBoxLocator = By.Id("department");
        private static By _submitButtonLocator = By.Id("submit");

        private static By _firstNameTableColumnLocator =
            By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][1]");

        private static By _lastNameTableColumnLocator =
            By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][2]");

        private static By _ageTableColumnLocator = By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][3]");

        private static By _emailTableColumnLocator =
            By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][4]");

        private static By _salaryTableColumnLocator =
            By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][5]");

        private static By _departmentTableColumnLocator =
            By.XPath("//div[@role=\"rowgroup\"][4]//div[@role=\"gridcell\"][6]");

        public static void OpenWebTablesPage() // method opens WebTables page
        {
            OpenBasePage();
            OpenElementsPage();
            OpenWebTablesElementPage();
        }

        public static void ClickAddButton() // method clicks Add Button
        {
            Driver().FindElement(_addButtonLocator).Click();
        }

        public static bool
            IsRegistrationFormModalLabelDisplayed() // returns "true" if Registration Form Modal is opened (Registration Form Modal Label is displayed)
        {
            return Driver().FindElement(_registrationFormModalLabelLocator).Displayed;
        }

        public static void SetFirstNameValue(string firstName) // entering value to First Name field
        {
            Driver().FindElement(_firstNameTextBoxLocator).SendKeys(firstName);
        }

        public static void SetLastNameValue(string lastName) // entering value to Last Name field
        {
            Driver().FindElement(_lastNameTextBoxLocator).SendKeys(lastName);
        }

        public static void SetEmailValue(string email) // entering value to Email field
        {
            Driver().FindElement(_emailTextBoxLocator).SendKeys(email);
        }

        public static void SetAgeValue(string age) // entering value to Age field
        {
            Driver().FindElement(_ageTextBoxLocator).SendKeys(age);
        }

        public static void SetSalaryValue(string salary) // entering value to Salary field
        {
            Driver().FindElement(_salaryTextBoxLocator).SendKeys(salary);
        }

        public static void SetDepartmentValue(string department) // entering value to Department field
        {
            Driver().FindElement(_departmentTextBoxLocator).SendKeys(department);
        }

        public static void ClickSubmitButton() // method clicks Submit Button
        {
            Driver().FindElement(_submitButtonLocator).Click();
        }

        public static string GetFirstNameTableColumnValue() => Driver().FindElement(_firstNameTableColumnLocator).Text;
        // method returns value of First Name table column

        public static string GetLastNameTableColumnValue() => Driver().FindElement(_lastNameTableColumnLocator).Text;
        // method returns value of Last Name table column

        public static string GetAgeTableColumnValue() => Driver().FindElement(_ageTableColumnLocator).Text;

        // method returns value of Age table column
        public static string GetEmailTableColumnValue() => Driver().FindElement(_emailTableColumnLocator).Text;
        // method returns value of Email table column

        public static string GetSalaryTableColumnValue() => Driver().FindElement(_salaryTableColumnLocator).Text;
        // method returns value of Salary table column

        public static string GetDepartmentTableColumnValue() =>
            Driver().FindElement(_departmentTableColumnLocator).Text;
        // method returns value of Department table column
    }
}