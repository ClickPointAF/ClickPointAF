﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Lead Source")]
    public partial class LeadSourceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "LeadReceiver.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Lead Source", "Workflow to create a Lead Source into a new Campaign", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Lead Source From Welcome Section")]
        [NUnit.Framework.CategoryAttribute("DeleteLead")]
        public void CreateLeadSourceFromWelcomeSection()
        {
            string[] tagsOfScenario = new string[] {
                    "DeleteLead"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Lead Source From Welcome Section", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("the user navigates to \"Welcome\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("the user clicks on \"Create a Lead Source\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Email",
                            "Country",
                            "Address",
                            "Address2",
                            "City",
                            "State",
                            "ZipCode"});
                table1.AddRow(new string[] {
                            "Jorge Chavez",
                            "ljorchavez@gmail.com",
                            "United States",
                            "Greenway Rd",
                            "",
                            "Phoenix",
                            "Arizona",
                            "85032"});
#line 8
 testRunner.When("the user inputs the following Lead Source data table", ((string)(null)), table1, "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Channel",
                            "Lead Type",
                            "Price",
                            "RequireAuth"});
                table2.AddRow(new string[] {
                            "Contact Us",
                            "Web Leads",
                            "Other",
                            "100",
                            "true"});
#line 11
 testRunner.And("the user inputs the following Campaign data table", ((string)(null)), table2, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "DuplicateDays",
                            "StandardizeAddress",
                            "AppendCity",
                            "MobileCheck",
                            "GeolocateIP",
                            "DeliveryCount",
                            "DeliversTo"});
                table3.AddRow(new string[] {
                            "30",
                            "false",
                            "false",
                            "false",
                            "false",
                            "5",
                            "Any Qualified Clients"});
#line 14
 testRunner.And("the user inputs the following Propertie data table", ((string)(null)), table3, "And ");
#line hidden
#line 17
 testRunner.And("the user navigates to \"Lead Source List\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("the user validates that the new Lead Source is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Lead Source From Inbound Section")]
        [NUnit.Framework.CategoryAttribute("DeleteLead")]
        public void CreateLeadSourceFromInboundSection()
        {
            string[] tagsOfScenario = new string[] {
                    "DeleteLead"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Lead Source From Inbound Section", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
 testRunner.Given("the user navigates to \"Lead Source List\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.And("the user clicks on \"Create Button\" in the \"Lead Source Page\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Email",
                            "Country",
                            "Address",
                            "Address2",
                            "City",
                            "State",
                            "ZipCode"});
                table4.AddRow(new string[] {
                            "Luis Chavez",
                            "luis_jorge95@hotmail.com",
                            "United States",
                            "Greenway Rd",
                            "",
                            "Phoenix",
                            "Arizona",
                            "85032"});
#line 24
 testRunner.When("the user inputs the following Lead Source data table", ((string)(null)), table4, "When ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Channel",
                            "Lead Type",
                            "Price",
                            "RequireAuth"});
                table5.AddRow(new string[] {
                            "Contact Us",
                            "Web Leads",
                            "Other",
                            "100",
                            "true"});
#line 27
 testRunner.And("the user inputs the following Campaign data table", ((string)(null)), table5, "And ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "DuplicateDays",
                            "StandardizeAddress",
                            "AppendCity",
                            "MobileCheck",
                            "GeolocateIP",
                            "DeliveryCount",
                            "DeliversTo"});
                table6.AddRow(new string[] {
                            "30",
                            "false",
                            "false",
                            "false",
                            "false",
                            "5",
                            "Any Qualified Clients"});
#line 30
 testRunner.And("the user inputs the following Propertie data table", ((string)(null)), table6, "And ");
#line hidden
#line 33
 testRunner.And("the user navigates to \"Lead Source List\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("the user validates that the new Lead Source is created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Lead")]
        [NUnit.Framework.CategoryAttribute("CreateCampaignWithLead")]
        public void DeleteLead()
        {
            string[] tagsOfScenario = new string[] {
                    "CreateCampaignWithLead"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Lead", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
 testRunner.Given("the user navigates to \"Lead Source List\" section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.When("the user deletes the recently created Lead Source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("the user validates that the new Lead Source is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Screenshot Test")]
        public void ScreenshotTest()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Screenshot Test", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
 testRunner.Given("the fail tests and tries to take a screenshot", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
