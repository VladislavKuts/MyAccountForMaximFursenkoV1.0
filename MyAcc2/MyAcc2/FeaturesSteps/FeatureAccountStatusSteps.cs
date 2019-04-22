using MyAcc2.POM;
using System;
using TechTalk.SpecFlow;

namespace MyAcc2.FeaturesSteps
{
    [Binding]
    public class FeatureAccountStatusBlockSteps : DocumentsPagePOM
    {
        [Given(@"User is log in and account status page is opened")]
        public void GivenUserIsLogInAndAccountStatusPageIsOpened()
        {
            LogInAndGoToAccStatus();
        }
        
        [When(@"I select account in Account status page")]
        public void WhenISelectAccountInAccountStatusPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select Start-date")]
        public void WhenISelectStart_Date()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select End-date")]
        public void WhenISelectEnd_Date()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click Show Report button")]
        public void WhenIClickShowReportButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Selected dates matches with showed period before general info")]
        public void ThenSelectedDatesMatchesWithShowedPeriodBeforeGeneralInfo()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Selected dates matches with showed period after general info")]
        public void ThenSelectedDatesMatchesWithShowedPeriodAfterGeneralInfo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
