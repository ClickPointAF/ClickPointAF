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
    public class LeadSourceSteps : CommonResources
    {
        public LeadSourceSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [When(@"the user inputs the following Lead Source data table")]
        public void WhenTheUserInputsTheFollowingLeadSourceData(Table table)
        {
            LeadSource lead = table.CreateInstance<LeadSource>();
            _leadSourcePage.CreateLead(lead);
        }

        [Then(@"the user validates that the new Lead Source is created")]
        public void ThenTheUserValidatesThatTheNewLeadSourceIsCreated(Table table)
        {
            LeadSource lead = table.CreateInstance<LeadSource>();
            Assert.That(_leadSourcePage.LeadSourceDisplayed(lead), Is.True);
        }

    }
}