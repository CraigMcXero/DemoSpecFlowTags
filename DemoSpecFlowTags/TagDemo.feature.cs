// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace DemoSpecFlowTags
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tag demonstrator")]
    public partial class TagDemonstratorFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TagDemo.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tag demonstrator", "In order to show the capabilities of tags in SpecFlow\nAs a developer\nI want to wr" +
                    "ite scenarios that has tags and show their usage in code", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Ignored scenario")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void IgnoredScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Ignored scenario", new string[] {
                        "ignore"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("that my scenario has the @ignore tag");
#line 10
 testRunner.When("I run the scenario");
#line 11
 testRunner.Then("the scenario is ignored");
#line 12
  testRunner.And("the missing step definitions are not reported");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario without tag")]
        public virtual void AScenarioWithoutTag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario without tag", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("that my scenario has no tags");
#line 16
 testRunner.When("I run the scenario");
#line 17
 testRunner.Then("before scenario hook without tag is run");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario with 1 tag")]
        [NUnit.Framework.CategoryAttribute("testTag1")]
        public virtual void AScenarioWith1Tag()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario with 1 tag", new string[] {
                        "testTag1"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("that my scenario has 1 tag");
#line 22
 testRunner.When("I run the scenario");
#line 23
 testRunner.Then("before scenario hook with the tag is run");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A scenario with 3 tags")]
        [NUnit.Framework.CategoryAttribute("testTag1")]
        [NUnit.Framework.CategoryAttribute("testTag2")]
        [NUnit.Framework.CategoryAttribute("testTag3")]
        public virtual void AScenarioWith3Tags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A scenario with 3 tags", new string[] {
                        "testTag1",
                        "testTag2",
                        "testTag3"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("that my scenario has 3 tags");
#line 28
 testRunner.When("I run the scenario");
#line 29
 testRunner.Then("before scenario hook with the tags is run");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
