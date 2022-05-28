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
    class Program
    {
        static void Main(string[] args)
        {
            //var options = new ChromeOptions();
            // options.BinaryLocation = "/";
            //IWebDriver driver = new ChromeDriver("F:/ChromeDriver", options);//new ChromeDriver();
            //Console.Write("test case started ");
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://lrms.icar.gov.in");
            //Thread.Sleep(2000);
            //IWebElement el_username = driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername"));
            //el_username.SendKeys("support.lrms");
            //IWebElement el_password = driver.FindElement(By.Id("ContentPlaceHolder1_txtPassword"));
            //el_password.SendKeys("Passw@rd#123");
            //IWebElement elb = driver.FindElement(By.Name("ctl00$ContentPlaceHolder1$ButtonSignIn"));
            //elb.Click();
            ////Thread.Sleep(3000);
            //driver.Close();
            //Console.Write("test case ended ");
            Console.Write("test case started ");
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(2000);
            // identify the Google search text box  
            IWebElement ele = driver.FindElement(By.Name("q"));
            //enter the value in the google search text box  
            ele.SendKeys("javatpoint tutorials");
            Thread.Sleep(1000);
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            ele1.Click();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://www.javatpoint.com/");
            //Thread.Sleep(3000);
            //close the browser  
            driver.Close();
            Console.Write("test case ended ");
        }
    }
}
