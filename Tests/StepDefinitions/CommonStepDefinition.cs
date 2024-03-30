using TechTalk.SpecFlow;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class CommonSteps : CommonResources
    {
        public CommonSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"the user navigates to ""([^""]*)"" section")]
        public void GivenTheUserNavigatesToSection(string sectionName)
        {
            _navbarPageObject.ClickButton("NavBarButtons", "Navbar Page", sectionName);
        }

        [Given(@"the user clicks ""([^""]*)"" button")]
        [When(@"the user clicks ""([^""]*)"" button")]
        public void GivenTheUserClicksButton(string buttonText)
        {
            _commonPageObject.ClickButton("CommonButton", "Common Page", buttonText);
                
        }
    }
}