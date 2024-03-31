using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TestSolution.Models;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class LeadSourceSteps : CommonResources
    {
        public LeadSourceSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [When(@"the user inputs the following Lead Source data table")]
        public void WhenTheUserInputsTheFollowingLeadSourceData(Table table)
        {
            LeadSource lead = table.CreateInstance<LeadSource>();
            _leadSourcePage.CreateLead(lead);

            _scenarioContext["LeadData"] = lead;
        }

        [When(@"the user deletes the recently created Lead Source")]
        public void WhenTheUserSelectsTheRecentlyCreatedLead()
        {
            var lead = (LeadSource)_scenarioContext["LeadData"];
            _leadSourcePage.DeleteLead(lead);
        }

        [Then(@"the user validates that the new Lead Source is deleted")]
        public void WhenTheUserClicksDedDeleteButton()
        {
            var lead = (LeadSource)_scenarioContext["LeadData"];
            Thread.Sleep(2000);
            Assert.That(_leadSourcePage.LeadSourceDisplayed(lead), Is.False);
        }

        [Then(@"the user validates that the new Lead Source is created")]
        public void ThenTheUserValidatesThatTheNewLeadSourceIsCreated()
        {
            var lead = (LeadSource)_scenarioContext["LeadData"];
            Assert.That(_leadSourcePage.LeadSourceDisplayed(lead), Is.True);
        }

    }
}