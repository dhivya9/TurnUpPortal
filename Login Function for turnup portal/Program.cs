
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

PageObjectModel loginpages = new PageObjectModel();

internal class PageObjectModel
{
}

IWebElement username = driver.FindElement(By.Id("UserName"));
username.SendKeys("hari");
IWebElement password=driver.FindElement(By.Id("Password"));
password.SendKeys("123123");
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();
IWebElement loginpage = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (loginpage != null) 
{
    Console.WriteLine("user logeed in successfully");
}
else
    {
    Console.WriteLine("user are logged in properly");
}
