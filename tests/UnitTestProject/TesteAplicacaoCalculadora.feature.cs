﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature : Xunit.IClassFixture<UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "TesteAplicacaoCalculadora.feature"
#line hidden
        
        public UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature(UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Usuário vai ter uma calculadora para efetuar soma", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Usuário informar 2 números inteiros e efetuar a soma")]
        [Xunit.TraitAttribute("FeatureTitle", "Usuário vai ter uma calculadora para efetuar soma")]
        [Xunit.TraitAttribute("Description", "Usuário informar 2 números inteiros e efetuar a soma")]
        [Xunit.TraitAttribute("Category", "TesteSomaSucesso")]
        public virtual void UsuarioInformar2NumerosInteirosEEfetuarASoma()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usuário informar 2 números inteiros e efetuar a soma", null, new string[] {
                        "TesteSomaSucesso"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("que o usuário esteja na aplicação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 6
 testRunner.And("informe no primeiro campo o valor 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 7
 testRunner.And("informe no segundo campo o valor 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 8
 testRunner.When("clicar em somar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 9
 testRunner.Then("vai ter como resultado 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Usuário informar em um dos campos uma letra e então validar")]
        [Xunit.TraitAttribute("FeatureTitle", "Usuário vai ter uma calculadora para efetuar soma")]
        [Xunit.TraitAttribute("Description", "Usuário informar em um dos campos uma letra e então validar")]
        [Xunit.TraitAttribute("Category", "TesteSomaPassandoTexto")]
        public virtual void UsuarioInformarEmUmDosCamposUmaLetraEEntaoValidar()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Usuário informar em um dos campos uma letra e então validar", null, new string[] {
                        "TesteSomaPassandoTexto"});
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 13
 testRunner.Given("que o usuário esteja na aplicação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.And("informe no primeiro campo o valor 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.And("informe no segundo campo o valor A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.When("clicar em somar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 17
 testRunner.Then("vai ter um alerta com o seguinte texto \"Informe somente números nos campos\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsuarioVaiTerUmaCalculadoraParaEfetuarSomaFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
