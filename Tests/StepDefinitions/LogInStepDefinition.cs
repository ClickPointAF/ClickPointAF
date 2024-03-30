using ConfigurationProvider.Classes;
using CsvHelper;
using TechTalk.SpecFlow;
using TestSolution.Models;

namespace TestSolution.StepDefinitions
{
    [Binding]
    public class LogInSteps : CommonResources
    {
        public LogInSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"the user navigates to the landing page")]
        public void GivenTheUserNavigatesToTheLandingPage()
        {
            _factory.NavigateToBaseUrl();
        }

        [When(@"the user inputs correct credentials to log in")]
        public void WhenTheUserInputsCorrectCredentialsToLogIn()
        {
            _loginPageObject.LoginUser(AppSettings.Instance.AdminUser);
        }

        [When(@"the user inputs incorrect credentials to log in")]
        public void WhenTheUserInputsInorrectCredentialsToLogIn()
        {
            User incorrectUser = new User()
            {
                Email = "incorrectUser@gmail.com",
                Password = "incorrectPassword"
            };
            _loginPageObject.LoginUser(incorrectUser);
        }

        [Then(@"the user should be succesfully logged in")]
        public void ThenTheUserShouldBeSuccesfullyLoggedIn()
        {
            _navbarPageObject.IsDisplayed("LoggedInText", "Navbar Page");
            _navbarPageObject.IsDisplayed("LoggedInMail", "Navbar Page", AppSettings.Instance.AdminUser.Email!);
        }

        [Then(@"the user should not be succesfully logged in")]
        public void ThenTheUserShouldNotBeSuccesfullyLoggedIn()
        {
            _loginPageObject.IsDisplayed("BadLogInAlert", "Navbar Page");
        }

    }
}