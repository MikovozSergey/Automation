using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.britishairways.com/travel/home/public/en_us";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));

            driver.FindElement(By.Id("planTripFlightDestination")).SendKeys("Frankfurt, Frankfurt (Fra), Germany");
            driver.FindElement(By.ClassName("calendarIcon depDate")).Click();
            driver.FindElement(By.XPath("//*[@ui-state-default ui-state-active='31']")).Click();
            driver.FindElement(By.ClassName("calendarIcon retDate")).Click();
            driver.FindElement(By.XPath("//*[@ui-state-default ui-state-active='7']")).Click();
            driver.FindElement(By.Id("flightSearchButton")).Click();

        }
    }
}
