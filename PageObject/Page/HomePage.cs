using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AirlinesTestingApp.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private const string url = "https://www.britishairways.com/travel/home/public/en_us";
        By addPassenger = By.Id("sb-Flight-pax-mix");
        By plusBaby = By.CssSelector(".disable:nth-child(2)");
        By errorsMessages = By.ClassName("messages");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddPassengers(){
            driver.FindElement(addPassenger).Click();
        }

        public void PlusBaby(int count = 1)
        {
            for (int i = 0; i < count; i++)
            {
                driver.FindElement(plusBaby).Click();
            }
        }

        public IWebElement GetErrorsMessages()
        {
            return driver.FindElement(errorsMessages);
        }
    }
}
