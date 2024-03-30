using ConfigurationProvider.Classes;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestSolution.Models;
using TestSolution.PageObjects;
using WebDriverProvider.Classes;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class CommonResources
    {
        protected readonly ScenarioContext _scenarioContext;
        protected readonly WebDriverFactory _factory;
        protected readonly CommonPage _commonPageObject;
        protected readonly NavbarPage _navbarPageObject;
        protected readonly LeadSourcePage _leadSourcePage;
        protected readonly CampaignPage _campaignPage;
        protected readonly PropertiePage _propertiePage;

        public CommonResources(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _factory = (WebDriverFactory)_scenarioContext["DriverFactory"];
            _commonPageObject = new CommonPage(_factory);
            _navbarPageObject = new NavbarPage(_factory);
            _leadSourcePage = new LeadSourcePage(_factory);
            _campaignPage = new CampaignPage(_factory);
            _propertiePage = new PropertiePage(_factory);
        }
    }
}