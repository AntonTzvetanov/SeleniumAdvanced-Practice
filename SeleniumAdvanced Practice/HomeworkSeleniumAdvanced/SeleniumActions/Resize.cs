using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumWeb.Pages
{
    [TestFixture]

    class InterationTestResize
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            _driver.Navigate().GoToUrl("https://demoqa.com/resizable/");

        }

        [Test]

        public void ResizeBoxWith100px()
        {
            var box = _driver.FindElement(By.Id("resizableBoxWithRestriction"));
            double boxWidth = box.Size.Width;
            double boxHeight = box.Size.Height;

            var resizeHandle = _driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

            var builder = new Actions(_driver);
            builder
                .DragAndDropToOffset(resizeHandle, 100, 100)
                .Perform();

            Assert.AreEqual(boxWidth + 100, box.Size.Width,"fail with cordinate X");
            Assert.AreEqual(boxHeight + 100, box.Size.Height,"fail with cordinate Y");

        }

        [Test]
        public void ResizeBoxWith250px()
        {

            var box = _driver.FindElement(By.Id("resizableBoxWithRestriction"));
            double boxWidth = box.Size.Width;
            double boxHeight = box.Size.Height;

            var resizeHandle = _driver.FindElement(By.XPath("//*[@id='resizableBoxWithRestriction']/span"));

            var builder = new Actions(_driver);
            builder
                .DragAndDropToOffset(resizeHandle, 250, 250)
                .Perform();

            Assert.AreEqual(boxWidth + 250, box.Size.Width,"error in condinate X ");
            Assert.AreEqual(boxHeight + 100, box.Size.Height,"error i cordinate Y ");

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
