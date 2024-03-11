using OpenQA.Selenium;


namespace Login_Function_for_turnup_portal.pages
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

        public void LoginPagemethod(IWebDriver driver, string enterusername, string enterpassword)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
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
            if (loginpage != null)
            {
                Console.WriteLine("user logeed in successfully");
            }
            else
            {
                Console.WriteLine("user are logged in properly");
            }

        }



    }
}

