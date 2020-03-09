using DemoProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Utilities
{
    class CommonDriver
    {
        // init webdriver globally
        public IWebDriver driver { set; get; }

        [OneTimeSetUp]
        public void StartUpSteps()
        {
            // define driver
            driver = new ChromeDriver();

            // page object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void FinishTestRun()
        {
            // Close the browser
            driver.Close();
        }
    }
}