using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Testing1.pages
{
    class Customerpage
    {
        public void ADDCustomerTest(IWebDriver driver)
        {
            // lines of code to validate create new customer test
            // click Create New button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // enter a name
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("NAME");

            // click the edit contact
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();


            // enter description
            driver.FindElement(By.XPath("//*[@id='PreferedName']")).SendKeys("TESTING");

            // click the savebutton 
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            // save the details in the customer page
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            // wait
            //Thread.Sleep(1000);

            // go to last page
            //driver.FindElement(By.XPath("")).Click();

            Thread.Sleep(1000);

            //// verify if the created time and material record is present
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "WIN")
            //{
            //    Console.WriteLine("TM created successfully, test passed");
            //}
            //else
            //{
            //    //dummy line added
            //    Console.WriteLine("Test failed");
            //}

        }

        public void EditCustomerTest(IWebDriver driver)
        {
            // lines of code to validate edit new customer test
            // wait
            Thread.Sleep(1000);

            //click the edit button
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[1]/td[4]/a[1]")).Click();

            //edit the details
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("command");

            //click the save button
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

        }
        public void DeleteCustomerTest(IWebDriver driver)
        {
            // lines of code to validate delete new customer test
            // To delete a function
            Thread.Sleep(1000);
            //click the delete button
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[1]/td[4]/a[2]")).Click();
        }

    }

}
