using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject.Pages
{
    class TMPage
    {
        public void AddTM(IWebDriver driver)
        {
            // click Create New button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // enter a code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("up");

            // enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("test");

            // save the time and material record
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            // wait
            Thread.Sleep(1000);

            // go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();

            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text, Is.EqualTo("up"));

            // verify if the created time and material record is present
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[1]")).Text == "up")
            {
                Console.WriteLine("TM created successfully, test failed");
            }
            else
            {
                // dummy line added
                Console.WriteLine("Test passed");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            //write the lines of code that performs and validates edit test cases
        }

        public void DeleteTM(IWebDriver driver)
        {
            //write the lines of code that performs and validates edit test cases
        }
    }
}

//        public void EditTM(IWebDriver driver)
//        {
//            // To edit a file

//            // wait
//            Thread.Sleep(1000);

//            //click the edit button
//            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();

//            //edit the details
//            driver.FindElement(By.XPath("//*[@id = 'Code']")).SendKeys("WINning");

//            //click the save button
//            driver.FindElement(By.XPath("//*[@id = 'SaveButton']")).Click();

//            //assert


//        }

//        public void DeleteTM(IWebDriver driver)
//        {
//            // To delete a function
//            Thread.Sleep(1000);
//            //click the delete button
//            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[2]")).Click();


//        }


//    }

//}
