using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo_Testing1.pages
{
    class TMpage
    {
        public void AddTM(IWebDriver driver)
        {
            // click Create New button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // enter a code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("WIN");

            // enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("TESTING");

            // save the time and material record
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            // wait
            Thread.Sleep(1000);

            // go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            Thread.Sleep(1000);

            // verify if the created time and material record is present
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "WIN")
            {
                Console.WriteLine("TM created successfully, test passed");
             }
               else
             {
               //dummy line added
               Console.WriteLine("Test failed");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            // To edit a file

            // wait
            Thread.Sleep(1000);

            //click the edit button
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

            //edit the details
            driver.FindElement(By.XPath("//*[@id = 'Code']")).SendKeys("WINning");

            //click the save button
            driver.FindElement(By.XPath("//*[@id = 'SaveButton']")).Click();


        }

        public void DeleteTM(IWebDriver driver)
        {
            // To delete a function
            Thread.Sleep(1000);
            //click the delete button
            driver.FindElement(By.XPath("")).Click();

            // click the ok button
            driver.FindElement(By.XPath("")).Click();
        }


    }

}
