using Demo_Testing1.pages;
using DemoProject.Pages;
using DemoProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject

// Test Condition (Manual) - TestFixture (Automated)
// Test Case (Manual) - Test (Automated)
{
    class Program
    {
        static void Main(string[] args)
        {

            //// define driver
            //CommonDriver.driver = new ChromeDriver();

            //// page object for login page
            //LoginPage loginObj = new LoginPage();
            //loginObj.LoginSteps(CommonDriver.driver);

            //// page object for home page
            //HomePage homeObj = new HomePage();
            //homeObj.NavigateToTM(CommonDriver.driver);

            //// page object for TM page
            //TMPage tmObj = new TMPage();

            //// create new TM test case
            //tmObj.AddTM(CommonDriver.driver);

            //// edit TM test case
            //tmObj.EditTM(CommonDriver.driver);

            //// delete TM test case
            //tmObj.DeleteTM(CommonDriver.driver);

            //// object for customer page
            //CustomersPage custObj = new CustomersPage();

            //// create new customer test
            //custObj.AddCustomerTest();

            //// edit customer test
            //custObj.EditCustomerTest();

            //// delete customer test
            //custObj.DeleteCustomerTest();
        }
    }

    [TestFixture, Description("Time and Material Test Cases")]
    //[Parallelizable]
    class TimeandMaterialTestSuite : CommonDriver
    {
        [Test, Description("Check if an user is able to add TM with valid data")]
        public void AddNewTMTest()
        {
            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // page object for TM page
            TMPage tmObj = new TMPage();

            // create new TM test case
            tmObj.AddTM(driver);
        }

        [Test, Description("Check if an user is able to edit TM with valid data")]
        public void EditTMTest()
        {
            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // page object for TM page
            TMPage tmObj = new TMPage();

            // edit TM test case
            tmObj.EditTM(driver);
        }

        [Test, Description("Check if an user is able to delete TM with valid data")]
        public void DeleteTMTest()
        {
            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // page object for TM page
            TMPage tmObj = new TMPage();

            // delete TM test case
            tmObj.DeleteTM(driver);
        }
    }

    [TestFixture, Description("Customer Test Cases")]
    //[Parallelizable]
    class CustomerTestSuite : CommonDriver
    {
        [Test, Description("Check if an user is able to add Customer with valid data")]
        public void AddNewCustomerTest()
        {
            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);

            // object for customer page
            Customerpage custObj = new Customerpage();

            // create new customer test
            custObj.ADDCustomerTest();
        }

        [Test, Description("Check if an user is able to edit Customer with valid data")]
        public void EditCustomerTest()
        {
            // object for customer page
            Customerpage custObj = new Customerpage();

            // edit customer test
            custObj.EditCustomerTest();
        }

        [Test, Description("Check if an user is able to delete Customer with valid data")]
        public void DeleteCustomerTest()
        {
            // object for customer page
            Customerpage custObj = new Customerpage();

            // delete customer test
            custObj.DeleteCustomerTest();
        }
    }
}