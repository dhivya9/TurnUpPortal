using OpenQA.Selenium;


namespace Login_Function_for_turnup_portal.pages
{
    public class Homepage
    {
        public readonly By administrationbuttonlocator = By.XPath("//*[@role='button']");
        public readonly By customerlocator = By.XPath("//*[contains(text(),'Customers')]");

        public void Homepagemethod(IWebDriver driver)
        {
            IWebElement Administartionbutton = driver.FindElement(administrationbuttonlocator);
            Administartionbutton.Click();

            IWebElement Customer = driver.FindElement(customerlocator);
            Customer.Click();
        }


    }
}
