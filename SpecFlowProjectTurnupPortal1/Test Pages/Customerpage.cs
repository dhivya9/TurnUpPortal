
using NUnit.Framework;
using OpenQA.Selenium;

using System.Configuration;
using System.Security.Cryptography.X509Certificates;


namespace SpecFlowProjectTurnupPortal1.Test_pages 
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

        private readonly By preferedname = By.Id("PreferedName");
        private IWebElement prefername;

        private readonly By phonenumber = By.Id("Phone");
        IWebElement phoneno;

        private readonly By mobile = By.Id("Mobile");
        private IWebElement mobileno;

        private readonly By Email=By.Id("email");
        private IWebElement email;

        private readonly By fax = By.Id("Fax");
        private IWebElement faxno;

        private readonly By address=By.Id("autocomplete");
        private IWebElement address1; 

        private readonly By street = By.Id("Street");
        private IWebElement street1;

        private readonly By city = By.Id("City");
        private IWebElement city1;

        private readonly By postcode = By.Id("Postcode");
        private IWebElement postcode1;

        private readonly By country = By.Id("Country");
        private IWebElement country1;

        private readonly By savebutton = By.Id("submitButton");
        private IWebElement save;

        private readonly By issamebutton = By.Id("IsSameContact");
        private IWebElement issamebutton1;

        public  readonly By editbillingcontact = By.Id("EditBillingContactButton");
        IWebElement editbilling;

        public readonly By gst = By.Id("GST");
       IWebElement gst1;

        public readonly By submitbutton = By.Id("submitButton");
        IWebElement submit;

        public readonly By administrationbuttonlocator = By.XPath("//*[@role='button']");
        IWebElement adminbutton;

        public readonly By customerlocator = By.XPath("//*[contains(text(),'Customers')]");
        IWebElement customer;

        private readonly By lastpagebutton = By.XPath("//*[contains(text(),'Go to the last page')]");
        IWebElement lastpage;

        private readonly By newrecordvalidation = By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]");
        IWebElement Newrecordvalidtaion;




        public void Newcustomercreation(IWebDriver driver)
        {

            createnew = driver.FindElement(createnewbuttonlocator);
            createnew.Click();



            Name = driver.FindElement(Namelocator);
            Name.Click();
            Name.SendKeys("Jeshan");

            Thread.Sleep(2000);


            contact = driver.FindElement(contactlocator);
            contact.Click();
            Thread.Sleep(1000);

            driver.SwitchTo().Frame(0);

            firstname = driver.FindElement(editcontactfirstname);
            firstname.Click();
            firstname.SendKeys("dhivya");

            lastname = driver.FindElement(editcontactlastname);
            lastname.Click();

            lastname.SendKeys("G");

            prefername = driver.FindElement(preferedname);
            prefername.Click();
            //string Pname = ConfigurationManager.AppSettings["prefername"];
            prefername.SendKeys("GD");

            phoneno = driver.FindElement(phonenumber);
            phoneno.Click();
            //string Pno = ConfigurationManager.AppSettings["Phoneno"];
            phoneno.SendKeys("012345679");

            mobileno = driver.FindElement(mobile);
            mobileno.Click();
            //string Mno = ConfigurationManager.AppSettings["mobileno"];
            mobileno.SendKeys("12346789");

            email = driver.FindElement(Email);
            email.Click();
            //string mailid = ConfigurationManager.AppSettings["email"];
            email.SendKeys("abcd@gmail.com");

            faxno = driver.FindElement(fax);
            faxno.Click();
            //string Fno = ConfigurationManager.AppSettings["faxno"];
            faxno.SendKeys("1234");

            address1 = driver.FindElement(address);
            address1.Click();
            //string Address = ConfigurationManager.AppSettings["address1"];
            address1.SendKeys("sydney");

            street1 = driver.FindElement(street);
            street1.Click();
            //string Street = ConfigurationManager.AppSettings["street1"];
            street1.SendKeys("Campbell street");

            city1 = driver.FindElement(city);
            city1.Click();
            //string City = ConfigurationManager.AppSettings["city1"];
            city1.SendKeys("parramatta");

            postcode1 = driver.FindElement(postcode);
            postcode1.Click();
            //string Postcode = ConfigurationManager.AppSettings["postcode1"];
            postcode1.SendKeys("2150");

            country1 = driver.FindElement(country);
            country1.Click();
            //string Country = ConfigurationManager.AppSettings["country1"];
            country1.SendKeys("Australia");

            save = driver.FindElement(savebutton);
            save.Click();

            driver.SwitchTo().DefaultContent();

            issamebutton1 = driver.FindElement(issamebutton);
            issamebutton1.Click();

            editbilling = driver.FindElement(editbillingcontact);
            //editbilling.Click();

            Assert.IsFalse((editbilling.Enabled), " Edit Billing Conact should be disable if you click is same as above");

            gst1 = driver.FindElement(gst);
            gst1.Click();
            //string GST = ConfigurationManager.AppSettings["gst1"];
            gst1.SendKeys("25");

            Thread.Sleep(1000);

            submit = driver.FindElement(submitbutton);
            submit.Click();

            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\screenshot\\windowscreen1" + System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine("Defect:createnew page didn't get load to main customer page ");

            driver.Navigate().Refresh();

            Thread.Sleep(1000);
        }

        public void Validatenewcustomerrecord(IWebDriver driver)
        {



            adminbutton = driver.FindElement(administrationbuttonlocator);
            adminbutton.Click();

            customer = driver.FindElement(customerlocator);
            customer.Click();
            Thread.Sleep(1000);


            lastpage = driver.FindElement(lastpagebutton);
            lastpage.Click();
            Thread.Sleep(1000);

            Newrecordvalidtaion = driver.FindElement(newrecordvalidation);
            Newrecordvalidtaion.Click();
            Assert.IsTrue((Newrecordvalidtaion.Text == "Jeshan"), "The New Customer record created ");
        
        }
        















        
        
        
    }
}
