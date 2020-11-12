using NUnit.Framework;
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
    class InteractionTestSortable
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;

        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.Navigate().GoToUrl("https://demoqa.com/sortable/");

        }

        [Test]

        public void SortItem2toItem1()
        {
            var item1 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[1]"));
            var item2 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[2]"));

            var item1Location = item1.Location.X;


            Actions builder = new Actions(_driver);

            builder.ClickAndHold(item1).Build().Perform();
            builder.MoveToElement(item2).Build().Perform();
            builder.Release(item1).Perform();

            var afterItem1Location = item1.Location.X;


            Assert.AreEqual(afterItem1Location, item1Location);


        }

        [Test]

        public void SortItem3toItem2()
        {

            var item1 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[2]"));
            var item2 = _driver.FindElement(By.XPath("//*[@id='sortable']/li[3]"));

            var item1Location = item1.Location.X;
            var item2Location = item2.Location.Y;


            Actions builder = new Actions(_driver);

            builder
                .ClickAndHold(item1)
                .Build()
                .Perform();
            builder
                .MoveToElement(item2)
                .Build()
                .Perform();
            builder
                .Release(item1)
                .Perform();

            var afterItem1Location = item1.Location.X;
            var afterItem2Location = item2.Location.Y;

            Assert.AreEqual(afterItem1Location, item1Location);


        }

        [TearDown]
        public void TearDown()
        {

            _driver.Quit();
        }

    }
}
