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
    public class PropertieSteps : CommonResources
    {
        public PropertieSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [When(@"the user inputs the following Propertie data table")]
        public void WhenTheUserInputsTheFollowingPropertieData(Table table)
        {
            Propertie propertie = table.CreateInstance<Propertie>();
            _propertiePage.CreatePropertie(propertie);
        }


    }
}