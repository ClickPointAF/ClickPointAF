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

        [When(@"the user double clicks the recently created campaign")]
        public void WhenTheUserDoubleClicksTheRecentlyCreatedCampaign()
        {
            var campaign = (Campaign)_scenarioContext["CampaignData"];
            _campaignPage.DoubleClickButton("CampaignRow", "Campaign Page", campaign.Name!, campaign.LeadType!);
        }

        [When(@"the user changes the price to ""([^""]*)""")]
        public void WhenTheUserChangesThePriceTo(string newPrice)
        {
            if(newPrice == "random")
            {
                Random random = new Random();
                newPrice = random.Next(0, 1001).ToString();
            }
            _campaignPage.WriteInput("EditCampaignPriceTextbox", "Campaign Page", newPrice);
            _campaignPage.ClickButton("CampaignSave", "Campaign Page");
        }



    }
}