﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EShopApplicationWebSolution.Features.WebTests
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login_EShopApplication")]
    [NUnit.Framework.CategoryAttribute("ui")]
    [NUnit.Framework.CategoryAttribute("owner=kritsha")]
    [NUnit.Framework.CategoryAttribute("web")]
    [NUnit.Framework.CategoryAttribute("testplan=574712")]
    [NUnit.Framework.CategoryAttribute("testsuite=574715")]
    public partial class Login_EShopApplicationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "ui",
                "owner=kritsha",
                "web",
                "testplan=574712",
                "testsuite=574715"};
        
#line 1 "EShopApplication_Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/WebTests", "Login_EShopApplication", "As a user, I want to be able to login to the EShop application", ProgrammingLanguage.CSharp, new string[] {
                        "ui",
                        "owner=kritsha",
                        "web",
                        "testplan=574712",
                        "testsuite=574715"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that a registered user is able to login into EShop application")]
        [NUnit.Framework.CategoryAttribute("testcase=574719")]
        [NUnit.Framework.CategoryAttribute("bvt")]
        [NUnit.Framework.CategoryAttribute("priority=1")]
        [NUnit.Framework.CategoryAttribute("version=1")]
        public virtual void VerifyThatARegisteredUserIsAbleToLoginIntoEShopApplication()
        {
            string[] tagsOfScenario = new string[] {
                    "testcase=574719",
                    "bvt",
                    "priority=1",
                    "version=1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that a registered user is able to login into EShop application", null, tagsOfScenario, argumentsOfScenario);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.When("user launches EShop application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And("user clicks on \"Login\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("user enters \"Email\" and \"Password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("user clicks on \"LOG IN\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.Then("user should be logged-in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that the user is unable to login to EShop Application if user is not regis" +
            "tered already")]
        [NUnit.Framework.CategoryAttribute("bddcore-ex")]
        [NUnit.Framework.CategoryAttribute("testcase=574720")]
        [NUnit.Framework.CategoryAttribute("priority=2")]
        [NUnit.Framework.CategoryAttribute("version=1")]
        [NUnit.Framework.TestCaseAttribute("InvalidUser1", null)]
        [NUnit.Framework.TestCaseAttribute("InvalidUser2", null)]
        [NUnit.Framework.TestCaseAttribute("InvalidUser3", null)]
        public virtual void VerifyThatTheUserIsUnableToLoginToEShopApplicationIfUserIsNotRegisteredAlready(string user, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "testcase=574720",
                    "priority=2",
                    "version=1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("user", user);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that the user is unable to login to EShop Application if user is not regis" +
                    "tered already", null, tagsOfScenario, argumentsOfScenario);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
 testRunner.Given("the user is not registered to EShop application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
 testRunner.When("user launches EShop application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("user clicks on \"Login\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("user enters email and password of \"{0}\"", user), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("user clicks on \"LOG IN\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.Then("the user should not be able to login to the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that the user is unable to login to EShop Application if user is not regis" +
            "tered already")]
        [NUnit.Framework.CategoryAttribute("testcase=574720")]
        [NUnit.Framework.CategoryAttribute("priority=2")]
        [NUnit.Framework.CategoryAttribute("version=1")]
        [NUnit.Framework.CategoryAttribute("bddcore-wrapper")]
        public virtual void VerifyThatTheUserIsUnableToLoginToEShopApplicationIfUserIsNotRegisteredAlready()
        {
            this.VerifyThatTheUserIsUnableToLoginToEShopApplicationIfUserIsNotRegisteredAlready("InvalidUser1", null);
            this.VerifyThatTheUserIsUnableToLoginToEShopApplicationIfUserIsNotRegisteredAlready("InvalidUser2", null);
            this.VerifyThatTheUserIsUnableToLoginToEShopApplicationIfUserIsNotRegisteredAlready("InvalidUser3", null);
        }
    }
}
#pragma warning restore
#endregion
