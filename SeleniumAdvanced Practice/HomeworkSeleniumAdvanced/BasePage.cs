using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HomeworkSeleniumAdvanced
{
    public abstract class BasePage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(2));
        }


        public IWebDriver Driver => _driver;

        public WebDriverWait Wait => _wait;


        public void Maximize()
        {

            Driver.Manage().Window.Maximize();

        }



        public void Navigate()
        {

            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        

    }


}
