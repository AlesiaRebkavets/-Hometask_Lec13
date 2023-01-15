using System.Threading;
using Hometask_Lec13.Wrappers;
using OpenQA.Selenium;

namespace Hometask.Pages
{
    public class RadioButtonPage: BasePage
    {
        // saving locators of RadioButton page
        private BaseElement _impressiveRadioButton = new BaseElement(By.XPath("//*[text()='Impressive']"));
        private BaseElement _youHaveSelectedLabel =
            new BaseElement(By.XPath("//*[@class='text-success'][text()='Impressive']"));

        // passing URL to the constructor
        public RadioButtonPage(): base("https://demoqa.com/radio-button"){}

        // method clicks Impressive Radio Button
        public void ClickImpressiveRadioButton()
        {
            Thread.Sleep(1000);
            _impressiveRadioButton.ScrollIntoViewScript();
            _impressiveRadioButton.Click();
        }

        // method returns 'true' if YouHaveSelectedLabel is displayed
        public bool IsYouHaveSelectedLabelDisplayed => _youHaveSelectedLabel.Displayed;

        // method returns text of YouHaveSelected label
        public string GetYouHaveSelectedLabelText => _youHaveSelectedLabel.Text;
    }
}