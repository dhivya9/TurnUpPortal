using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;


namespace SpecFlowProjectTurnupPortal1.Test_pages
{
    public class Customereditpage
    {
        public readonly By administrationbuttonlocator = By.XPath("//*[@role='button']");
        IWebElement adminbutton;

        public readonly By customerlocator = By.XPath("//*[contains(text(),'Customers')]");
        IWebElement customer;

        private readonly By lastpagebutton = By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]/span");
        IWebElement lastpage;

        private readonly By newrecordvalidation = By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]");
        IWebElement Newrecordvalidtaion;

        private readonly By Editelement = By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[4]/a[1]");
        IWebElement editbutton;

        private readonly By Namelocator1 = By.Id("Name");
        IWebElement Name1;

        private readonly By contactlocator = By.Id("EditContactButton");
        IWebElement contact;

        private readonly By editcontactfirstname = By.Id("FirstName");
        private IWebElement firstname1;

        private readonly By editcontactlastname = By.Id("LastName");
        private IWebElement lastname2;

        private readonly By savebutton = By.Id("submitButton");
        private IWebElement save;

        public readonly By gst = By.Id("GST");
        IWebElement gst1;

        private readonly By submitbutton = By.XPath("//*[@id=\'submitButton\']");
        private IWebElement submit;

        private readonly By newrecordvalidation1 = By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]");
        IWebElement Newrecordvalidtaion1;


        private readonly By deletebutton = By.XPath("//table/tbody/tr[last()]/td[4]/a[2]");
        private IWebElement Deletebutton;

        public readonly By deleteelement = By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[last()]/td[2]");
        IWebElement Deleteelement;


        public void gotolastpage(IWebDriver driver)

        {
            adminbutton = driver.FindElement(administrationbuttonlocator);
            adminbutton.Click();

            customer = driver.FindElement(customerlocator);
            customer.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            lastpage = driver.FindElement(lastpagebutton);
            lastpage.Click();
            Thread.Sleep(1000);

             Newrecordvalidtaion = driver.FindElement(newrecordvalidation);
            Newrecordvalidtaion.Click();

        }
        public void Cuseditpage(IWebDriver   driver, string Names, string firstname, string lastname,string GST)

        {

           


          // Newrecordvalidtaion = driver.FindElement(newrecordvalidation);
            //Newrecordvalidtaion.Click();


            editbutton = driver.FindElement(Editelement);
            editbutton.Click();

            driver.SwitchTo().Frame(0);
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            Name1 = driver.FindElement(Namelocator1);
            Name1.Click();
            Name1.Clear();
            // string Editname= ConfigurationManager.AppSettings["Name1"];
            Name1.SendKeys(Names);


            contact = driver.FindElement(contactlocator);
            contact.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);

            driver.SwitchTo().Frame(0);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);

            firstname1 = driver.FindElement(editcontactfirstname);
            firstname1.Click();
            firstname1.Clear();
            firstname1.SendKeys(firstname);

            lastname2 = driver.FindElement(editcontactlastname);
            lastname2.Click();
            lastname2.Clear();
            lastname2.SendKeys(lastname);

            save = driver.FindElement(savebutton);
            save.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);

            driver.SwitchTo().ParentFrame();

            gst1 = driver.FindElement(gst);
            gst1.Click();
            gst1.Clear();
            //string GST = ConfigurationManager.AppSettings["gst1"];
            gst1.SendKeys(GST);


            Thread.Sleep(1000);

            
            submit = driver.FindElement(submitbutton);
            submit.Click();

            Thread.Sleep(1000);

            driver.Navigate().Refresh();

        }
        
        public void validateedit(IWebDriver driver)
        {

          

            adminbutton = driver.FindElement(administrationbuttonlocator);
            adminbutton.Click();

            customer = driver.FindElement(customerlocator);
            customer.Click();
            


            lastpage = driver.FindElement(lastpagebutton);
            lastpage.Click();
            


            Newrecordvalidtaion = driver.FindElement(newrecordvalidation);
            Newrecordvalidtaion.Click();
            Assert.That((Newrecordvalidtaion.Text == "Jeshvitha"), "The New Customer record Edited ");

        }




        public void Cusdeletepage(IWebDriver driver)
        {

            //dminbutton = driver.FindElement(administrationbuttonlocator);
            //adminbutton.Click();

            //customer = driver.FindElement(customerlocator);
            //customer.Click(); 

            lastpage = driver.FindElement(lastpagebutton);
            lastpage.Click();
            Thread.Sleep(1000);

            Deletebutton = driver.FindElement(deletebutton);
            Deletebutton.Click();

            Thread.Sleep(1000);

            IAlert deletepopupwindow = driver.SwitchTo().Alert();
            deletepopupwindow.Accept();

            Thread.Sleep(1000);
            
            Deleteelement = driver.FindElement(deleteelement);
            Deleteelement.Click();
            Assert.That((Deleteelement.Text != "Jeshvitha"), "Time Record has been deleted");

            

            



            


        }
        
        
    }
}
