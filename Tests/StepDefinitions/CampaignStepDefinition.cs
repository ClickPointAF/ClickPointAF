using ConfigurationProvider.Classes;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSolution.Models;
using TestSolution.PageObjects;
using WebDriverProvider.Classes;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class CampaignSteps : CommonResources
    {
        public CampaignSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [When(@"the user inputs the following Campaign data table")]
        public void WhenTheUserInputsTheFollowingCampaignData(Table table)
        {
            Campaign campaign = table.CreateInstance<Campaign>();
            _campaignPage.CreateCampaign(campaign);
        }


    }
}