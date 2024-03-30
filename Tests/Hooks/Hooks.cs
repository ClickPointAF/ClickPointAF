using Allure.Net.Commons;
using ConfigurationProvider.Classes;
using WebDriverProvider.Classes;
using WebDriverProvider.Configurations;
using TestSolution.Models;
using System.Text.Json;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using TestSolution.PageObjects;
using ConfigurationProvider;
using System.Collections;

namespace TestSolution.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly string _webDriverConfigurationJson;
        public static AllureLifecycle allure = AllureLifecycle.Instance;
        public Hooks(ScenarioContext scenarioContext)
        {
            _webDriverConfigurationJson = "Configurations//appsettings.json";
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            allure.CleanupResultDirectory();
        }

        [BeforeFeature]
        public static void logBeforeFeatureExecution(FeatureContext _featureContext)
        {
            Logger.WriteLine("================= Feature: " + _featureContext.FeatureInfo.Title + " =================");
        }

        [BeforeScenario]
        public static void logBeforeScenarioExecution(ScenarioContext _scenarioContext)
        {
            DictionaryEntry args = _scenarioContext.ScenarioInfo.Arguments.Cast<DictionaryEntry>().FirstOrDefault();
            Logger.WriteLine("*** Scenario: " + _scenarioContext.ScenarioInfo.Title + (args.Value == null ? "" : " (" + args.Value + ")") + " ***"); ;
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            var configurationReader = new ConfigurationReader(AppContext.BaseDirectory + _webDriverConfigurationJson);
            var configuration = configurationReader.GetConfiguration<WebDriverConfiguration>();
            if (Environment.GetEnvironmentVariable("GITHUB_ACTIONS") == "true")
            {
                configuration.IsRemote = true;
            }
            var factory = new WebDriverFactory(configuration);
            var _loginPage = new LoginPage(factory);

            var scenarioTags = _scenarioContext.ScenarioInfo.Tags.ToList();
            if (!scenarioTags.Contains("LogInFeature"))
            {
                factory.NavigateToBaseUrl();
                _loginPage.LoginUser(AppSettings.Instance.AdminUser);
            }

            scenarioContext["DriverFactory"] = factory;
        }

        [AfterStep]
        public static void logAfterStepExecution(ScenarioContext _scenarioContext)
        {
            string statusMessage = "Status: ";
            if (_scenarioContext.TestError != null)
            {
                statusMessage = "FAILED" + " => " + _scenarioContext.TestError.Message;
            }
            else
            {
                statusMessage = "PASSED";
            }

            Logger.WriteLine(statusMessage);
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            var factory = (WebDriverFactory)scenarioContext["DriverFactory"];

            if (factory is not null)
            {
                var driver = factory.GetInstanceOf();

                if (driver is not null)
                {
                    factory.TerminateWebDriver();
                }
            }
        }
    }
}
