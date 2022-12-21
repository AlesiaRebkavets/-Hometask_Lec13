using System;
using Hometask.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Hometask.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Browser.Maximize();
            Browser.SetImplicitlyWait();        // implicit timeout is 30 sec
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Browser.Quit();               // close driver after executing all the tests
        }
    }
}