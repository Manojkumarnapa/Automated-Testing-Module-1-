using DemoProject.Pages;
using DemoProject.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DemoProject.StepDefinitions
{
    [Binding]
    class TimeAndMaterialSteps : CommonDriver
    {
        [Given(@"I have logged in TurnUp portal")]
        public void GivenIHaveLoggedInTurnUpPortal()
        {
            // define driver
            driver = new ChromeDriver();

            // page object for login page
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }

        [Given(@"I navigate to Time and Material page")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // page object for home page
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }

        [Then(@"I should be able to create time record with valid information")]
        public void ThenIShouldBeAbleToCreateTimeRecordWithValidInformation()
        {
            // page object for TM page
            TMPage tmObj = new TMPage();

            // create new TM test case
            tmObj.AddTM(driver);
        }

        [Then(@"I should be able to edit time record with updated information")]
        public void ThenIShouldBeAbleToEditTimeRecordWithUpdatedInformation()
        {
            // page object for TM page
            TMPage tmObj = new TMPage();

            // edit TM test case
            tmObj.EditTM(driver);

            // quit driver
            driver.Quit();
        }

    }
}
