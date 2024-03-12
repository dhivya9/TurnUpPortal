using NUnit.Framework;
using OpenQA.Selenium;


namespace SpecFlowProjectTurnupPortal1.Test_pages
{
    public class LoginPage

    {

        private readonly By usernamelocator = By.Id("UserName");
        IWebElement username;
        public readonly By passwordlocator = By.Id("Password");
        IWebElement password;
        public readonly By Loginbuttonlocator = By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]");
        IWebElement loginbutton;
        public readonly By loginpagelocator = By.XPath("//*[@id=\"logoutForm\"]/ul/li/a");
        IWebElement loginpage;
        public readonly By administrationbuttonlocator = By.XPath("//*[@role='button']");
        IWebElement administrationbutton;
        public readonly By customerlocator = By.XPath("//*[contains(text(),'Customers')]");
        IWebElement customer;

        
        public void LoginPagemethod(IWebDriver driver, string enterusername, string enterpassword)
        {
            
            username = driver.FindElement(usernamelocator);
            username.SendKeys(enterusername);
            Thread.Sleep(1000);
            password = driver.FindElement(passwordlocator);
            password.SendKeys(enterpassword);

          loginbutton = driver.FindElement(Loginbuttonlocator);
            loginbutton.Click();
        }
        public void Validatelogin(IWebDriver driver)

        {
            loginpage = driver.FindElement(loginpagelocator);
 
            Assert.That((loginpage.Text.Equals("Hello hari!")), "user loged in successfully");

        }
        public void Homepagemethod(IWebDriver driver)
        {
            administrationbutton = driver.FindElement(administrationbuttonlocator);
            administrationbutton.Click();

            customer = driver.FindElement(customerlocator);
            customer.Click();
        }



    }
}

