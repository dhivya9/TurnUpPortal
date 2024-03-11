using Login_Function_for_turnup_portal.tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Function_for_turnup_portal.pages
{
    public class program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

               LoginPage loginPage = new LoginPage();
                loginPage.LoginPagemethod(driver, "hari", "123123");

                loginPage.Validatelogin(driver);
                Console.WriteLine("user login successfully");
           
          
                Homepage homepage = new Homepage();
                homepage.Homepagemethod(driver);

                Customerpage customerpage = new Customerpage();
                customerpage.customerpagemethod(driver);
                string  Name = ConfigurationManager.AppSettings["Name"];
                
            }
}
}


    

