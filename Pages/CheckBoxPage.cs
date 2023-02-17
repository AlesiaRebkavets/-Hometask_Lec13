using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class CheckBoxPage: BasePage
    {
        // saving locators of CheckBox page
        private BaseElement _homeCollapseButton = new BaseElement(By.XPath("//*[@type='button'][..//@for='tree-node-home']"));
        private BaseElement _documentsCollapseButton = new BaseElement(By.XPath("//*[@for='tree-node-documents']/../*[@type='button']"));
        private BaseElement _officeCollapseButton = new BaseElement(By.XPath("//*[@for='tree-node-office']/../*[@type='button']"));
        private BaseElement _privateCheckbox = new BaseElement(By.XPath("//*[@for='tree-node-private']"));
        private BaseElement _classifiedCheckbox =
            new BaseElement(By.XPath("//*[@for='tree-node-classified']"));
        private BaseElement _youHaveSelectedLabelTextPrivateOption =
            new BaseElement(By.XPath("//*[@class='text-success'][text()='private']"));
        private BaseElement _youHaveSelectedLabelTextClassifiedOption =
            new BaseElement(By.XPath("//*[@class='text-success'][text()='classified']"));

        // passing URL to the constructor
        public CheckBoxPage(): base("https://demoqa.com/checkbox"){}

        // method clicks Home Collapse button 
        public void ClickHomeCollapseButton()
        {
            _homeCollapseButton.ScrollIntoViewScript();
            _homeCollapseButton.Click();
        }

        // method clicks Documents Collapse button 
        public void ClickDocumentsCollapseButton()
        {
            _documentsCollapseButton.ScrollIntoViewScript();
            _documentsCollapseButton.Click();
        }

        // method clicks Office Collapse button 
        public void ClickOfficeCollapseButton()
        {
            _officeCollapseButton.ScrollIntoViewScript();
            _officeCollapseButton.Click();
        }

        // method checks Private Checkbox 
        public void ClickPrivateCheckbox()
        {
            _privateCheckbox.ScrollIntoViewScript();
            _privateCheckbox.Click();
        }

        // method checks Classified Checkbox 
        public void ClickClassifiedCheckbox()
        {
            _classifiedCheckbox.ScrollIntoViewScript();
            _classifiedCheckbox.Click();
        }

        // method returns displayed final text
        public string GetDisplayedFinalText => $"{_youHaveSelectedLabelTextPrivateOption.Text} {_youHaveSelectedLabelTextClassifiedOption.Text}";
    }
}