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
    class InterationTestSelectable

    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            _driver.Navigate().GoToUrl("https://demoqa.com/selectable/");

        }

        [Test]

        public void SelectElementItem3and4()
        {


            var selectElement = _driver.FindElement(By.Id("selectable"));
            var Items = _driver.FindElement(By.XPath("//*[@id='selectable']"));
            var target = _driver.FindElement(By.Id("selectable"));

            var item3 = _driver.FindElement(By.XPath("//*[@id='selectable']/li[3]"));

            Actions builder = new Actions(_driver);
            builder.ClickAndHold(selectElement).ClickAndHold(item3).Release().Perform();

            Assert.AreEqual(item3.Text, "Item 3");

        }

        [Test]

        public void SelectElement1and5()
        {

            var element1 = _driver.FindElement(By.XPath("//*[@id='selectable']/li[1]"));
            var element5 = _driver.FindElement(By.XPath("//*[@id='selectable']/li[5]"));
            var Items = _driver.FindElement(By.XPath("//*[@id='selectable']"));
            Actions builder = new Actions(_driver);
            builder.ClickAndHold(element1).ClickAndHold(element5).Release().Perform();

            Assert.AreEqual(element5.Text,"Item 5");




        }

        [TearDown]
        public void TearDown()
        {

            _driver.Quit();
        }

    }
}
