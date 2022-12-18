using System;
using Hometask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class BaseTest
    {
        protected static IWebDriver _driver;
        
     //   private const string BaseUrl = "https://demoqa.com/forms";
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //BasePage.OpenBasePage();
            //_driver.Navigate().GoToUrl(BaseUrl);
            
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }

}