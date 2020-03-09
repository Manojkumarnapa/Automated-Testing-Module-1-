using DemoProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // maximize the browser
            driver.Manage().Window.Maximize();

            //Wait for login page to be loaded and username textbox be rendered
            Sync.WaitForVisiblity(driver, "Id", "UserName", 10);

            // populate login page test data collection
            ExcelLibHelpers.PopulateInCollection(@"S:\2020SecondBatch\DemoProject\DemoProject\TestData\TestData.xls", "LoginPage");

            // identify username and enter username value
            driver.FindElement(By.Id("UserName")).SendKeys(ExcelLibHelpers.ReadData(2, "Username"));

            // identify password and enter password
            driver.FindElement(By.Id("Password")).SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

            // identify login button and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            //Wait for login page to be loaded and username textbox be rendered
            Sync.WaitForVisiblity(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 5);

            try
            {
                // verify if the home page is displayed as expected
                if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
                {
                    Console.WriteLine("Test Passed");
                }
                else
                {
                    Console.WriteLine("Test Failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Home page not displayed", ex.Message);
            }



        }
    }
}



