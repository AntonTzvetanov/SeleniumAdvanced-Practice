using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Reflection;

namespace SeleniumWeb.Pages
{
    [TestFixture]
    class Negative_testing
    {
        private ChromeDriver _driver;
        private WebDriverWait _wait;


        [SetUp]

        public void TestInit()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
           
        }

        [Test]
        public void SkipLastNameOnRegistrationForm()
        {
            //Create Account 
            
            var еmailAddress = _driver.FindElement(By.Id("email_create"));
            еmailAddress.SendKeys("antontzvetanov@gmail.com");
            var createAccbutton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccbutton.Click();
            var radioButton = _driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("Stanislav");
            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("");
            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys("12341234");
            var dateDropDown = _driver.FindElement(By.Id("days"));

            //select Date of Birth 

            SelectElement date = new SelectElement(dateDropDown);
            date.SelectByValue("3");
            var addMonth = _driver.FindElement(By.Id("months"));
            SelectElement month = new SelectElement(addMonth);
            month.SelectByValue("3");
            var addYear = _driver.FindElement(By.Id("years"));
            SelectElement year = new SelectElement(addYear);
            year.SelectByValue("1990");

            // fill data for address

            var firstNameForRegistrationAddress = _driver.FindElement(By.Id("firstname"));
            firstNameForRegistrationAddress.SendKeys("Anton");
            var LastNameForRegistrationAddress = _driver.FindElement(By.Id("lastname"));
            var companyName = _driver.FindElement(By.Id("company"));
            companyName.SendKeys("Oryx");
            var inputAddress = _driver.FindElement(By.Id("address1"));
            inputAddress.SendKeys("test");
            var City = _driver.FindElement(By.Id("city"));
            City.SendKeys("Sofia");
            var stateName = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateName);
            state.SelectByValue("1");
            var postCode = _driver.FindElement(By.Id("postcode"));
            postCode.SendKeys("00000");
            var country = _driver.FindElement(By.Id("id_country"));
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByValue("21");
            var mobilePhone = _driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("003598999221");
            var AssignAddress = _driver.FindElement(By.Id("alias"));
            AssignAddress.SendKeys("Test");
            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

        }

        [Test]
        public void SkipFirstNameInRegistrationForm()
        {
            //Create Account 
            _driver.FindElement(By.ClassName("login")).Click();
            var EnterEmailAddress = _driver.FindElement(By.Id("email_create"));
            EnterEmailAddress.SendKeys("antontzvetanov@gmail.com");
            var createAccbutton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccbutton.Click();
            var radioButton = _driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("");
            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("Test");
            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys("12341234");
            var dateDropDown = _driver.FindElement(By.Id("days"));

            //select Date of Birth 

            SelectElement date = new SelectElement(dateDropDown);
            date.SelectByValue("3");
            var addMonth = _driver.FindElement(By.Id("months"));
            SelectElement month = new SelectElement(addMonth);
            month.SelectByValue("3");
            var addYear = _driver.FindElement(By.Id("years"));
            SelectElement year = new SelectElement(addYear);
            year.SelectByValue("1990");

            // fill data for address

            var FirstNameForRegistrationAddress = _driver.FindElement(By.Id("firstname"));
            FirstNameForRegistrationAddress.SendKeys("Anton");
            var LastNameForRegistrationAddress = _driver.FindElement(By.Id("lastname"));
            var CompanyName = _driver.FindElement(By.Id("company"));
            CompanyName.SendKeys("Oryx");
            var inputAddress = _driver.FindElement(By.Id("address1"));
            inputAddress.SendKeys("test");
            var City = _driver.FindElement(By.Id("city"));
            City.SendKeys("Sofia");
            var stateName = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateName);
            state.SelectByValue("1");
            var postCode = _driver.FindElement(By.Id("postcode"));
            postCode.SendKeys("00000");
            var country = _driver.FindElement(By.Id("id_country"));
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByValue("21");
            var mobilePhone = _driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("003598999221");
            var AssignAddress = _driver.FindElement(By.Id("alias"));
            AssignAddress.SendKeys("Test");
            var registerButton = _driver.FindElement(By.Id("submitAccount"));

            registerButton.Click();

        }

        [Test]

        public void SkipPasswordInRegistrationForm()
        {
            //Create Account 
            _driver.FindElement(By.ClassName("login")).Click();
            var EnterEmailAddress = _driver.FindElement(By.Id("email_create"));
            EnterEmailAddress.SendKeys("antontzvetanov@gmail.com");
            var createAccbutton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccbutton.Click();
            var radioButton = _driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("Test");
            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("Testov");
            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys("");
            var dateDropDown = _driver.FindElement(By.Id("days"));

            //select Date of Birth 

            SelectElement date = new SelectElement(dateDropDown);
            date.SelectByValue("3");
            var addMonth = _driver.FindElement(By.Id("months"));
            SelectElement month = new SelectElement(addMonth);
            month.SelectByValue("3");
            var addYear = _driver.FindElement(By.Id("years"));
            SelectElement year = new SelectElement(addYear);
            year.SelectByValue("1990");

            // fill data for address

            var FirstNameForRegistrationAddress = _driver.FindElement(By.Id("firstname"));
            FirstNameForRegistrationAddress.SendKeys("Anton");
            var LastNameForRegistrationAddress = _driver.FindElement(By.Id("lastname"));
            var CompanyName = _driver.FindElement(By.Id("company"));
            CompanyName.SendKeys("Oryx");
            var inputAddress = _driver.FindElement(By.Id("address1"));
            inputAddress.SendKeys("test");
            var City = _driver.FindElement(By.Id("city"));
            City.SendKeys("Sofia");
            var stateName = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateName);
            state.SelectByValue("1");
            var postCode = _driver.FindElement(By.Id("postcode"));
            postCode.SendKeys("00000");
            var country = _driver.FindElement(By.Id("id_country"));
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByValue("21");
            var mobilePhone = _driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("003598999221");
            var AssignAddress = _driver.FindElement(By.Id("alias"));
            AssignAddress.SendKeys("Test");
            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();

        }


        [Test]

        public void SkipAddressInRegistrationForm()
        {

            //Create Account 
            _driver.FindElement(By.ClassName("login")).Click();
            var EnterEmailAddress = _driver.FindElement(By.Id("email_create"));
            EnterEmailAddress.SendKeys("antontzvetanov@gmail.com");
            var createAccbutton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccbutton.Click();
            var radioButton = _driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("Me");
            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("Test");
            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys("12341234");
            var dateDropDown = _driver.FindElement(By.Id("days"));

            //select Date of Birth 

            SelectElement date = new SelectElement(dateDropDown);
            date.SelectByValue("3");
            var addMonth = _driver.FindElement(By.Id("months"));
            SelectElement month = new SelectElement(addMonth);
            month.SelectByValue("3");
            var addYear = _driver.FindElement(By.Id("years"));
            SelectElement year = new SelectElement(addYear);
            year.SelectByValue("1990");

            // fill data for address

            var FirstNameForRegistrationAddress = _driver.FindElement(By.Id("firstname"));
            FirstNameForRegistrationAddress.SendKeys("Anton");
            var LastNameForRegistrationAddress = _driver.FindElement(By.Id("lastname"));
            var CompanyName = _driver.FindElement(By.Id("company"));
            CompanyName.SendKeys("Oryx");
            var inputAddress = _driver.FindElement(By.Id("address1"));
            inputAddress.SendKeys("");
            var City = _driver.FindElement(By.Id("city"));
            City.SendKeys("Sofia");
            var stateName = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateName);
            state.SelectByValue("1");
            var postCode = _driver.FindElement(By.Id("postcode"));
            postCode.SendKeys("00000");
            var country = _driver.FindElement(By.Id("id_country"));
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByValue("21");
            var mobilePhone = _driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("003598999221");
            var AssignAddress = _driver.FindElement(By.Id("alias"));
            AssignAddress.SendKeys("Test");
            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();


        }

        [Test]

        public void SkipCityInRegistraionForm()
        {
            //Create Account 
            _driver.FindElement(By.ClassName("login")).Click();
            var EnterEmailAddress = _driver.FindElement(By.Id("email_create"));
            EnterEmailAddress.SendKeys("antontzvetanoпокхгйфдсv@gmail.com");
            var createAccbutton = _driver.FindElement(By.Id("SubmitCreate"));
            createAccbutton.Click();
            var radioButton = _driver.FindElement(By.Id("id_gender1"));
            radioButton.Click();
            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("Test");
            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("Test");
            var password = _driver.FindElement(By.Id("passwd"));
            password.SendKeys("12341234");
            var dateDropDown = _driver.FindElement(By.Id("days"));

            //select Date of Birth 

            SelectElement date = new SelectElement(dateDropDown);
            date.SelectByValue("3");
            var addMonth = _driver.FindElement(By.Id("months"));
            SelectElement month = new SelectElement(addMonth);
            month.SelectByValue("3");
            var addYear = _driver.FindElement(By.Id("years"));
            SelectElement year = new SelectElement(addYear);
            year.SelectByValue("1990");

            // fill data for address

            var FirstNameForRegistrationAddress = _driver.FindElement(By.Id("firstname"));
            FirstNameForRegistrationAddress.SendKeys("Anton");
            var LastNameForRegistrationAddress = _driver.FindElement(By.Id("lastname"));
            var CompanyName = _driver.FindElement(By.Id("company"));
            CompanyName.SendKeys("Oryx");
            var inputAddress = _driver.FindElement(By.Id("address1"));
            inputAddress.SendKeys("test");
            var City = _driver.FindElement(By.Id("city"));
            City.SendKeys("");
            var stateName = _driver.FindElement(By.Id("id_state"));
            SelectElement state = new SelectElement(stateName);
            state.SelectByValue("1");
            var postCode = _driver.FindElement(By.Id("postcode"));
            postCode.SendKeys("00000");
            var country = _driver.FindElement(By.Id("id_country"));
            SelectElement selectCountry = new SelectElement(country);
            selectCountry.SelectByValue("21");
            var mobilePhone = _driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("003598999221");
            var AssignAddress = _driver.FindElement(By.Id("alias"));
            AssignAddress.SendKeys("Test");
            var registerButton = _driver.FindElement(By.Id("submitAccount"));
            registerButton.Click();



        }



        [TearDown]
        public void TearDown()
        {
            _driver.Quit();

        }



    }

}

