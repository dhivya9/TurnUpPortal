using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectTurnupPortal1.Test_pages;
using SpecFlowProjectTurnupPortal1.Test_Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTurnupPortal1.StepDefinitions
{
    [Binding]
    public class NewCustomerRecordStepDefinitions : Commondriver
    {
        LoginPage loginPage = new LoginPage();
        Customereditpage customereditpage = new Customereditpage();

        [BeforeScenario]

        [Given(@"User able to login the turnup portal")]
        public void GivenUserAbleToLoginTheTurnupPortal()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();


            loginPage.LoginPagemethod(driver, "hari", "123123");


        }
        [AfterScenario]
        public void close()
        {
            driver.Quit();
        }

        [Given(@"User able to see the home page and customer page")]
        public void GivenUserAbleToSeeTheHomePageAndCustomerPage()
        {
            loginPage.Homepagemethod(driver);
        }

        [When(@"User able to create a new customer record")]
        public void WhenUserAbleToCreateANewCustomerRecord()
        {
            Customerpage customerPage = new Customerpage();
            customerPage.Newcustomercreation(driver);
        }

        [Then(@"User able to see new customer record in customer page")]
        public void ThenUserAbleToSeeNewCustomerRecordInCustomerPage()
        {
            Customerpage customerPage = new Customerpage();
            customerPage.Validatenewcustomerrecord(driver);

        }
        [Given(@"User able to see the customer page")]
        public void GivenUserAbleToSeeTheCustomerPage()
        {
            customereditpage.gotolastpage(driver);
        }

        [When(@"User able to edit the record '([^']*)''([^']*)''([^']*)'(.*)")]
        public void WhenUserAbleToEditTheRecord(string Names, string firstname, string latsname, string GST)
        {
            customereditpage.Cuseditpage(driver, Names, firstname, latsname, GST);
        }




        [Then(@"User able to see the edit record in customer page")]
        public void ThenUserAbleToSeeTheEditRecordInCustomerPage()
        {
           customereditpage.validateedit(driver);
        }

        [When(@"User able to delete the customer record")]
        public void WhenUserAbleToDeleteTheCustomerRecord()
        {
            customereditpage.Cusdeletepage(driver);
        }

        [Then(@"User validate that customer record is deleted\.")]
        public void ThenUserValidateThatCustomerRecordIsDeleted_()
        {
            Console.WriteLine("Customer Record Deleted");
        }


    }
}

