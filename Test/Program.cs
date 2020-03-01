using Demo_Testing1.pages;
using Demo_Testing1.utilities;
using java.sql;
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

// Test condition (manual) - Testfixture (automated)
// Test case (manual) - Test (automated)
{
    class Program
    {
        static void Main(string[] args)
        {
            //// define driver
            //CommonDriver.driver = new ChromeDriver();

            //// page object for login page
            //Loginpage loginObj = new Loginpage();
            //loginObj.Loginsteps(CommonDriver.driver);

            ////page object for home page
            //Homepage homeObj = new Homepage();
            //homeObj.NavigatetoTM(CommonDriver.driver);

            ////page object for TM page
            //TMpage tmObj = new TMpage();
            //// create new TM test case
            //tmObj.AddTM(CommonDriver.driver);

            //// edit TM test case
            //tmObj.EditTM(CommonDriver.driver);

            //// delete TM test case
            //tmObj.DeleteTM(CommonDriver.driver);

            ////Customerpage custobj = new Customerpage();
            ////// Create new customer test
            ////custobj.ADDCustomerTest();

            ////// Edit new customer test
            //custobj.EditCustomerTest();

            //// Delete new customer test
            //custobj.DeleteCustomerTest();











        }
    }

    [TestFixture ,Description ("Time and material test cases")]
    class TimeandmaterialTestsuite : CommonDriver 
    {
        [SetUp, Description("Check user able to start the page for TM")]
        public void Startupsteps()

        {
            // define driver
             driver = new ChromeDriver();

            // page object for login page
            Loginpage loginObj = new Loginpage();
            loginObj.Loginsteps(driver);

        }
        [Test, Description("check user able to add a data in TM")]
        public void AddNewTMTest()
        {
            //page object for home page
            Homepage homeObj = new Homepage();
            homeObj.NavigatetoTM(driver);

            //page object for TM page
            TMpage tmObj = new TMpage();
            // create new TM test case
            tmObj.AddTM(driver);
        }
        [Test, Description("check user able to edit a data in TM")]
        public void EditTMTest()
        {
            //page object for home page
            Homepage homeObj = new Homepage();
            homeObj.NavigatetoTM(driver);

            //page object for TM page
            TMpage tmObj = new TMpage();
            // create new TM test case
            tmObj.EditTM(driver);
        }
        [Test, Description("check user able to delete a data in TM")]
        public void DeleteTMtest()
        {
            //page object for home page
            Homepage homeObj = new Homepage();
            homeObj.NavigatetoTM(driver);

            //page object for TM page
            TMpage tmObj = new TMpage();
            // create new TM test case
            tmObj.DeleteTM(driver);
        }
        [TearDown]
        public void FinishTestrun()
        
            {
            driver.Close();
            } 
    }

    [TestFixture ,Description("customer test cases")]
    class CustomerTestsuite : CommonDriver
    {
        [SetUp, Description("Check user able to start the page for Customer")]
        public void Startupsteps()

        {
            //// define driver
            driver = new ChromeDriver();

            //// page object for login page
            Loginpage loginObj = new Loginpage();
            loginObj.Loginsteps(driver);

        }
        [Test, Description("Check user able to start the add data for customer")]
        public void AddNewCustomerTest()
        {
            ////page object for home page
            Homepage homeObj = new Homepage();
            homeObj.NavigatetoTM(driver);
            Customerpage custobj = new Customerpage();
            ////// Create new customer test
            custobj.ADDCustomerTest();

        }
        [Test, Description("Check user able to start the edit data for customer")]
        public void EditCustomerTest()
        {
            Customerpage custobj = new Customerpage();
            ////// Edit new customer test
            custobj.EditCustomerTest();
        }
        [Test, Description("Check user able to start the delete data for customer")]
        public void Deletecustomertest()
        {
            Customerpage custobj = new Customerpage();
            //// Delete new customer test
            custobj.DeleteCustomerTest();
        }
        [TearDown]
        public void FinishTestrun()

        {
            driver.Close(); 
        }
    }
}



