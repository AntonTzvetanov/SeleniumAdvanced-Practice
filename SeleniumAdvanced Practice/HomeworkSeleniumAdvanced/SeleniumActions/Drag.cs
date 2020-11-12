using NUnit.Framework;
using NUnit.Framework.Interfaces;
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

            _driver.Navigate().GoToUrl("https://demoqa.com/dragabble");

        }

        [Test]

        public void DragObjectX226Y81()
        {

            var dragableElement = _driver.FindElement(By.Id("dragBox"));
            var dragable = _driver.FindElement(By.Id("draggableExample-tabpane-containerRestriction"));
            var dragableElementX = dragable.Size.Width;
            var dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder
                .DragAndDropToOffset(dragableElement, 226, 81)
                .Perform();

            Assert.AreEqual(dragableElementX, 226,"Error in Cordinate X");
            Assert.AreEqual(dragableElementY, 81,"Error in Cordinate Y ");

        }

        [Test]

        public void DragObjectToX400Y210()
        {

            var dragableElement = _driver.FindElement(By.Id("dragBox"));
            var dragable = _driver.FindElement(By.Id("draggableExample-tabpane-containerRestriction"));
            var dragableElementX = dragable.Size.Width;
            var dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder
                .DragAndDropToOffset(dragableElement, 400, 210)
                .Perform();
            Assert.AreEqual(dragableElementX, 150);
            Assert.AreEqual(dragableElementY, 150);

        }

        [Test]

        public void DragObject()
        {

            var dragableElement = _driver.FindElement(By.Id("dragBox"));
            var dragable = _driver.FindElement(By.Id("draggableExample-tabpane-containerRestriction"));
            double dragableElementX = dragable.Size.Width;
            double dragableElementY = dragable.Size.Height;


            Actions builder = new Actions(_driver);
            builder
                .DragAndDropToOffset(dragableElement, 200, 100)
                .Perform();

            Assert.AreEqual(dragableElementX, dragable.Size.Width);
            Assert.AreEqual(dragableElementY, dragable.Size.Height);


            // Assert.AreEqual(boxWidth + 84, box.Size.Width);
            //Assert.AreEqual(boxHeight + 84, box.Size.Height);

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
