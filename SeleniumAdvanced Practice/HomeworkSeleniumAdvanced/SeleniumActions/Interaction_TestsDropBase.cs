using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumWeb
{
    [TestFixture]
    internal class Interaction_TestsDropBase
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;

        [Test]
        public void Dropable()
        {
            var dragable = _driver.FindElement(By.Id("draggable"));
            var target = _driver.FindElement(By.Id("droppable"));

            var dragX = dragable.Location.X;
            var dragY = dragable.Location.Y;

            var targetColor = target.GetCssValue("style");
            Actions builder = new Actions(_driver);

            builder.DragAndDropToOffset(dragable, 145, 25).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;
            var afterColor = target.GetCssValue("style");

        }

        [Test]

        public void DropToLocationX175()
        {
            var dragable = _driver.FindElement(By.Id("draggable"));
            var target = _driver.FindElement(By.Id("droppable"));

            var dragX = dragable.Location.X;
            var dragY = dragable.Location.Y;

            var targetColor = target.GetCssValue("style");
            Actions builder = new Actions(_driver);

            builder.DragAndDropToOffset(dragable, 350, 25).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;
            var afterColor = target.GetCssValue("style");

        }

        [Test]

        public void DropToLocationY45()
        {
            var dragable = _driver.FindElement(By.Id("draggable"));
            var target = _driver.FindElement(By.Id("droppable"));

            var dragX = dragable.Location.X;
            var dragY = dragable.Location.Y;

            var targetColor = target.GetCssValue("style");
            Actions builder = new Actions(_driver);

            builder.DragAndDropToOffset(dragable, 175, 200).Perform();

            var afterX = dragable.Location.X;
            var afterY = dragable.Location.Y;
            var afterColor = target.GetCssValue("style");

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


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.Navigate().GoToUrl("https://demoqa.com/droppable/");

        }
    }
}