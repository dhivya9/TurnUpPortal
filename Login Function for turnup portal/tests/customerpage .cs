using Login_Function_for_turnup_portal.pages;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using System.Configuration;

namespace Login_Function_for_turnup_portal.tests
{

    [TestFixture]
    public class customerpage : commondriver
    {
        [SetUp]
        public void setup()
        {

             driver = new ChromeDriver();

            LoginPage loginPage = new LoginPage();
            loginPage.LoginPagemethod(driver, "hari", "123123");

            loginPage.Validatelogin(driver);
            Console.WriteLine("user login successfully");
        }
        [Test]
        public void customerpageopening(string Name)
        {
            Homepage homepage = new Homepage();
            homepage.Homepagemethod(driver);

            Customerpage customerpage = new Customerpage();
            customerpage.customerpagemethod(driver);
            Name=ConfigurationManager.AppSettings["Name"];
        }
        [Test]
        public void customerediting()
        {

        }
        [Test]
        public void customerdeleting()
        {

        }
        [Test]
        public void closingpage()
        {

        }
    }
}