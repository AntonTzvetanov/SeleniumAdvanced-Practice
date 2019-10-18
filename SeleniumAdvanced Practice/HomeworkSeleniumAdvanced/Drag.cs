using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;

namespace SeleniumWeb
{
    [TestFixture]
    class InterationTestDrag

    {
        private ChromeDriver _driver;


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://demoqa.com/draggable/");

        }

        [Test]

        public void DragObjectX250Y135()
        {

            var dragableElement = _driver.FindElement(By.Id("draggable"));
            var dragable = _driver.FindElement(By.XPath("//*[@id='draggable']"));
            var dragableElementX = dragable.Size.Width;
            var dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder.DragAndDropToOffset(dragableElement, 250, 135).Perform();

            Assert.AreEqual(dragableElementX, 150);
            Assert.AreEqual(dragableElementY, 150);

        }

        [Test]

        public void DragObjectToX400Y210()
        {

            var dragableElement = _driver.FindElement(By.Id("draggable"));
            var dragable = _driver.FindElement(By.XPath("//*[@id='draggable']"));
            var dragableElementX = dragable.Size.Width;
            var dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder.DragAndDropToOffset(dragableElement, 400, 210).Perform();
            Assert.AreEqual(dragableElementX, 150);
            Assert.AreEqual(dragableElementY, 150);

        }

        [Test]

        public void DragObject()
        {

            var dragableElement = _driver.FindElement(By.Id("draggable"));
            var dragable = _driver.FindElement(By.XPath("//*[@id='draggable']"));
            double dragableElementX = dragable.Size.Width;
            double dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder.DragAndDropToOffset(dragableElement, 200, 100).Perform();

            Assert.AreEqual(dragableElementX, dragable.Size.Width);
            Assert.AreEqual(dragableElementY, dragable.Size.Height);


            // Assert.AreEqual(boxWidth + 84, box.Size.Width);
            //Assert.AreEqual(boxHeight + 84, box.Size.Height);

        }

        [TearDown]
        public void TearDown()
        {

            _driver.Quit();
        }

    }
}
