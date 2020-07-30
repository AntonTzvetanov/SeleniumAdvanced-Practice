using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeworkSeleniumAdvanced.NegativeTestCases.Pages
{
    public  class IWebElements : BasePage
    {

        public IWebElements(IWebDriver driver)
            :base(driver)
        {

        }

        public IWebElement LoginButton => Driver.FindElement(By.ClassName("login"));

        public IWebElement EmailAddress => Driver.FindElement(By.Id("email_create"));

        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));

        public IWebElement RadioButton => Driver.FindElement(By.Id("id_gender1"));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public SelectElement Days
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("days"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Months
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("months"));
                return new SelectElement(reminder);
            }
        }

        public SelectElement Years
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("years"));
                return new SelectElement(reminder);
            }
        }

       
        public IWebElement Address => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public SelectElement State
        {
            get
            {
                IWebElement reminder = Driver.FindElement(By.Id("id_state"));
                return new SelectElement(reminder);
            }
        }

        public IWebElement PostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement Phone => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement Alias => Driver.FindElement(By.Id("alias"));

        public IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));

        public IWebElement ErrorMessage => Driver.FindElement(By.XPath("//*[@id='center_column']/div/ol/li[1]"));




    }
}
