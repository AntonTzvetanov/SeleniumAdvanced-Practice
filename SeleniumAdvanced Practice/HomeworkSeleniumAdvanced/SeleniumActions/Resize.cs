using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;

namespace SeleniumWeb
{
    [TestFixture]

    class InterationTestResize
    {
        private ChromeDriver _driver;


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://demoqa.com/resizable/");

        }

        [Test]

        public void ResizeBoxWith100px()
        {
            var box = _driver.FindElement(By.Id("resizable"));
            double boxWidth = box.Size.Width;
            double boxHeight = box.Size.Height;

            var resizeHandle = _driver.FindElement(By.XPath("//*[@id='resizable']/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resizeHandle, 100, 100).Perform();
            Assert.AreEqual(boxWidth + 84, box.Size.Width);
            Assert.AreEqual(boxHeight + 84, box.Size.Height);


        }

        [Test]
        public void ResizeBoxWith250px()
        {

            var box = _driver.FindElement(By.Id("resizable"));
            double boxWidth = box.Size.Width;
            double boxHeight = box.Size.Height;

            var resizeHandle = _driver.FindElement(By.XPath("//*[@id='resizable']/div[3]"));

            var builder = new Actions(_driver);
            builder.DragAndDropToOffset(resizeHandle, 250, 250).Perform();
            Assert.AreEqual(boxWidth + 233, box.Size.Width);
            Assert.AreEqual(boxHeight + 233, box.Size.Height);

        }

        [TearDown]
        public void TearDown()
        {

            _driver.Quit();
        }

    }
}
