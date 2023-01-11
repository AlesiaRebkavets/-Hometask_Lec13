using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class WebTablesPage : Browser
    {
        // saving locators of WebTables page
        private const string WebTablesPageUrl = "https://demoqa.com/webtables";
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
            By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][1]");

        private static By _lastNameTableColumnLocator =
            By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][2]");

        private static By _ageTableColumnLocator = By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][3]");

        private static By _emailTableColumnLocator =
            By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][4]");

        private static By _salaryTableColumnLocator =
            By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][5]");

        private static By _departmentTableColumnLocator =
            By.XPath("//*[@role=\"rowgroup\"][4]//*[@role=\"gridcell\"][6]");

        public static void OpenWebTablesPage() => Driver().Navigate().GoToUrl(WebTablesPageUrl);
        // method opens WebTables page

        public static void ClickAddButton() => Driver().FindElement(_addButtonLocator).Click();
        // method clicks Add Button

        public static bool IsRegistrationFormModalLabelDisplayed() => Driver().FindElement(_registrationFormModalLabelLocator).Displayed;
        // returns "true" if Registration Form Modal is opened (Registration Form Modal Label is displayed)

        public static void SetFirstNameValue(string firstName) => Driver().FindElement(_firstNameTextBoxLocator).SendKeys(firstName);
        // entering value to First Name field

        public static void SetLastNameValue(string lastName) => Driver().FindElement(_lastNameTextBoxLocator).SendKeys(lastName);
        // entering value to Last Name field

        public static void SetEmailValue(string email) => Driver().FindElement(_emailTextBoxLocator).SendKeys(email);
        // entering value to Email field

        public static void SetAgeValue(string age) => Driver().FindElement(_ageTextBoxLocator).SendKeys(age);
        // entering value to Age field

        public static void SetSalaryValue(string salary) => Driver().FindElement(_salaryTextBoxLocator).SendKeys(salary);
        // entering value to Salary field

        public static void SetDepartmentValue(string department) => Driver().FindElement(_departmentTextBoxLocator).SendKeys(department);
        // entering value to Department field

        public static void ClickSubmitButton() => Driver().FindElement(_submitButtonLocator).Click();
        // method clicks Submit Button

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

        public static string GetDepartmentTableColumnValue() =>  Driver().FindElement(_departmentTableColumnLocator).Text;
        // method returns value of Department table column
    }
}