using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSolution.Models;

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