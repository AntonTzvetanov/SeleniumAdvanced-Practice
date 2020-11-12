using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumWeb
{
    [TestFixture]
    public class Tests
    {
        private ChromeDriver _driver;

        [SetUp]
        public void TestInit()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [Test]

        public void NavigateToGooglePage()
        {

            _driver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(_driver.Title.Contains("Google"));
        }


        [TearDown]
        public void TearDown()
        {
            var name = TestContext.CurrentContext.Test.Name;
            var result = TestContext.CurrentContext.Result.Outcome;

            if (result != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                var directory = Directory.GetCurrentDirectory();

                var fullPath = Path.GetFullPath("..\\..\\..\\Screenshots");

                screenshot.SaveAsFile(fullPath + name + ".png", ScreenshotImageFormat.Png);

            }
            _driver.Quit();


        }

    }
}
