using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace DemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // open up chrome browser
            IWebDriver driver = new ChromeDriver();

            // enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // maximize the browser
            //driver.Manage().Window.Maximize();

            // identify username and enter username value
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            // identify password and enter password
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            // identify login button and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            // verify if the home page is displayed as expected
           // if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            //{
              //  Console.WriteLine("Test Passed");
           // }
            //else
            //{
            //    Console.WriteLine("Test Failed");
            //}

            // To create a TIME AND MATERIAL

            // click on administration
             driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            // click on time and material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            // click Create New button
            //driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // enter a code
            //driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("WIN");

            // enter description
            //driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("TESTING");

            // save the time and material record
            //driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            // wait
            //Thread.Sleep(1000);

            // go to last page
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            // verify if the created time and material record is present
            // if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "WIN")
            //{
            //    Console.WriteLine("TM created successfully, test passed");
            // }
            //else
            // {
            // dummy line added
            //Console.WriteLine("Test failed");
            //}





         // To edit a file

            // wait
             //Thread.Sleep(1000);

            //click the edit button
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            //edit the details
            //driver.FindElement(By.XPath("//*[@id = 'Code']")).SendKeys("WINning");

            //click the save button
            //driver.FindElement(By.XPath("//*[@id = 'SaveButton']")).Click();



            // To delete a function
            Thread.Sleep(1000);
            //click the delete button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]")).Click();

            // click the ok button
            //driver.FindElement(By.XPath("")).Click();
        }
    }
}




