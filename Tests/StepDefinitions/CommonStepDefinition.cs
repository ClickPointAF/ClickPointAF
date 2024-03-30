using TechTalk.SpecFlow;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class CommonSteps : CommonResources
    {
        public CommonSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"the user navigates to ""([^""]*)"" section")]
        [When(@"the user navigates to ""([^""]*)"" section")]
        public void GivenTheUserNavigatesToSection(string sectionName)
        {
            _navbarPageObject.ClickButton("NavBarButtons", "Navbar Page", sectionName);
        }

        [Given(@"the user clicks on ""([^""]*)"" button")]
        [When(@"the user clicks on ""([^""]*)"" button")]
        public void GivenTheUserClicksButton(string buttonText)
        {
            _commonPageObject.ClickButton("CommonButton", "Common Page", buttonText);
                
        }

        [Given(@"the user clicks on ""([^""]*)"" in the ""([^""]*)""")]
        public void GivenTheUserClicksOnInThe(string elementName, string pageObject)
        {
            _commonPageObject.ClickButton(elementName, pageObject);
        }

    }
}