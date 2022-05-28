using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class NUnitTest
    {
        IWebDriver driver = new ChromeDriver();
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://mail.icar.gov.in/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        public void ExecutionTest()
        {
            //username
            //password
            IWebElement elu = driver.FindElement(By.Id("username"));
            elu.SendKeys("support.lrms@icar.gov.in");
            Thread.Sleep(2000);
            Console.Write("username value is entered");
            IWebElement elp = driver.FindElement(By.Id("password"));
            elp.SendKeys("Passw@rd#123");
            Thread.Sleep(2000);
            Console.Write("password value is entered");
            //IWebElement eleb = driver.FindElement(By.Id("u_0_b"));
            //eleb.Click();
            //Thread.Sleep(3000);
            //Console.Write("login button is clicked");
        }
        public void EndTest()
        {
            driver.Close();
        }
    }
}
