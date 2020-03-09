using System;
using TechTalk.SpecFlow;

namespace Demo_Testing1.Step_definitions
{
    [Binding]
    public class cutomersteps
    {
        [Given(@"I have log into  TurnUp portal")]
        public void GivenIHaveLogIntoTurnUpPortal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to customer page")]
        public void GivenINavigateToCustomerPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to create customer record with valid information")]
        public void ThenIShouldBeAbleToCreateCustomerRecordWithValidInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to edit customer record with updated information")]
        public void ThenIShouldBeAbleToEditCustomerRecordWithUpdatedInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
