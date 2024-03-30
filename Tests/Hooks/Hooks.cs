﻿using Allure.Net.Commons;
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
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Resources;
using CsvHelper;

namespace TestSolution.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly string _webDriverConfigurationJson;
        public static AllureLifecycle allure = AllureLifecycle.Instance;
        private WebDriverFactory? _factory;
        private LoginPage? _loginPage;
        private NavbarPage? _navbarPage;
        private LeadSourcePage? _leadSourcePage;
        private CampaignPage? _campaignPage;
        private PropertiePage? _propertiePage;

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
            Logger.WriteLine($"================= Feature: {_featureContext.FeatureInfo.Title} =================");
        }

        [BeforeScenario(Order = 0)]
        public static void logBeforeScenarioExecution(ScenarioContext _scenarioContext)
        {
            DictionaryEntry args = _scenarioContext.ScenarioInfo.Arguments.Cast<DictionaryEntry>().FirstOrDefault();
            Logger.WriteLine($"==== Scenario: {_scenarioContext.ScenarioInfo.Title} ====");
        }

        [BeforeStep]
        public static void LogBeforeStepExecution(ScenarioContext scenarioContext)
        {
            // Accessing the current step information
            var stepInfo = scenarioContext.StepContext.StepInfo;

            // Logging the step definition type (Given, When, Then) and the step text
            Logger.WriteLine($"Executing step [{stepInfo.StepDefinitionType}]: {stepInfo.Text}");
        }


        [BeforeScenario(Order = 1)]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            Logger.WriteLine($"==== BeforeScenario Hook: Create Driver ====");
            var configurationReader = new ConfigurationReader(AppContext.BaseDirectory + _webDriverConfigurationJson);
            var configuration = configurationReader.GetConfiguration<WebDriverConfiguration>();
            if (Environment.GetEnvironmentVariable("GITHUB_ACTIONS") == "true")
            {
                configuration.IsRemote = true;
            }
            _factory = new WebDriverFactory(configuration);
            _navbarPage = new NavbarPage(_factory);
            _leadSourcePage = new LeadSourcePage(_factory);
            _campaignPage = new CampaignPage(_factory);
            _propertiePage = new PropertiePage(_factory);
            _loginPage = new LoginPage(_factory);

            var scenarioTags = _scenarioContext.ScenarioInfo.Tags.ToList();
            if (!scenarioTags.Contains("LogInFeature"))
            {
                _factory.NavigateToBaseUrl();
                _loginPage.LoginUser(AppSettings.Instance.AdminUser);
            }

            scenarioContext["DriverFactory"] = _factory;
        }

        [BeforeScenario("CreateCampaignWithLead", Order = 2)]
        public void CreateCampaign(ScenarioContext scenarioContext)
        {
            Logger.WriteLine($"==== BeforeScenario Hook: CreateCampaignWithLead ====");
            var lead = new LeadSource()
            {
                Name = "Luis Chavez",
                Email = "luis_jorge95@hotmail.com",
                Country = "United States",
                Address = "Greenway Rd",
                Address2 = "",
                City = "Phoenix",
                State = "Arizona",
                ZipCode = "85032"
            };
            var campaign = new Campaign()
            {
                Name = "Contact Us",
                Channel = "Web Leads",
                LeadType = "Other",
                Price = "100",
                RequireAuth = true
            };
            var propertie = new Propertie()
            {
                DuplicateDays = "30",
                StandardizeAddress = false,
                AppendCity = false,
                MobileCheck = false,
                GeolocateIP = false,
                DeliveryCount = "5",
                DeliversTo = "Any Qualified Clients"
            };

            scenarioContext["LeadData"] = lead;
            scenarioContext["CampaignData"] = campaign;
            scenarioContext["PropertieData"] = propertie;

            _navbarPage?.ClickButton("NavBarButtons", "Navbar Page", "Lead Source List");
            _leadSourcePage?.ClickButton("Create Button", "Lead Source Page");
            _leadSourcePage?.CreateLead(lead);
            _campaignPage?.CreateCampaign(campaign);
            _propertiePage?.CreatePropertie(propertie);
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

        [AfterScenario("DeleteLead")]
        public void DeleteCampaignAndLead(ScenarioContext scenarioContext)
        {
            var lead = (LeadSource)scenarioContext["LeadData"];

            _navbarPage?.ClickButton("NavBarButtons", "Navbar Page", "Lead Source List");
            _leadSourcePage?.DeleteLead(lead);
            //_navbarPage?.ClickButton("NavBarButtons", "Navbar Page", "Campaigns");
            //_campaignPage?.DeleteCampaign(lead);
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
