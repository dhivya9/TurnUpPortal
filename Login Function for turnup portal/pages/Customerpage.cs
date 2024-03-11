using OpenQA.Selenium;


namespace Login_Function_for_turnup_portal.pages
{
    public class Customerpage
    {
        private readonly By createnewbuttonlocator = By.XPath("//*[contains(text(),'Create New')]");
        IWebElement createnew;
        private readonly By Namelocator = By.Id("Name");
        IWebElement Name;
        private readonly By contactlocator = By.Id("EditContactButton");
        IWebElement contact;
        private readonly By editcontactfirstname = By.Id("FirstName");
        private IWebElement firstname;
        private readonly By editcontactlastname = By.Id("LastName");
        private IWebElement lastname;
        private readonly By phonenumber = By.Id("Phone");
        IWebElement phoneno;
        private readonly By savebutton = By.Id("submitButton");
        private IWebElement save;

        public object ConfigurationManager { get; internal set; }

        public void customerpagemethod(IWebDriver driver)
        {
            createnew = driver.FindElement(createnewbuttonlocator);
            createnew.Click();

            Name = driver.FindElement(Namelocator);
            Name.Click();
          

            Thread.Sleep(2000);
        }
        public void editcontactpage(IWebDriver driver) 
        {
            contact = driver.FindElement(contactlocator);
            contact.Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Frame(0);

            firstname = driver.FindElement(editcontactfirstname);
            firstname.Click();
            

            lastname = driver.FindElement(editcontactlastname);
            lastname.Click();
            

            phoneno = driver.FindElement(phonenumber);
            phoneno.Click();
            


            save = driver.FindElement(savebutton);
            save.Click();

        }


    }
}
