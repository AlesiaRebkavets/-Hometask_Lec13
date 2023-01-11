using NUnit.Framework;

namespace Hometask.Tests
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void SetUp()
        // initial setup
        {
            Browser.Maximize();
            Browser.SetImplicitlyWait();        // set implicit timeout 
        }

        [OneTimeTearDown]
        // close driver after executing of all the tests
        public void TearDown()
        {
            Browser.Quit();                    
        }
    }
}