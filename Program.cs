using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
string baseURL = "https://automationintesting.com/selenium/testpage/";
//driver.Navigate().GoToUrl(baseURL);
driver.Url = baseURL;
driver.FindElement(By.Id("firstname")).SendKeys("Aiugikjuhhiwefsl");
driver.FindElement(By.Id("surname")).SendKeys("Dioadvsbsvrfsasvl");

new SelectElement((driver.FindElement(By.Id("gender")))).SelectByText("Male");
driver.FindElement(By.XPath(".//input[@value='Red']")).Click();
driver.FindElement(By.Id("checkbox1")).Click();

driver.FindElement(By.XPath(".//textarea[@placeholder='Tell us some fun stuff!']")).SendKeys("I just have started learning selenium augtomation testing");
Thread.Sleep(3000);
driver.FindElement(By.XPath("//*[@id='continent']/option[7]")).Click();

driver.FindElement(By.XPath(".//button[text()='I do nothing!']")).Click();


