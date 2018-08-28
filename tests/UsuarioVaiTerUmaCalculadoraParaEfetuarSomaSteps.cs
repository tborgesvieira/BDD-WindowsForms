using System;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using Xunit;

namespace UnitTestProject
{
    [Binding]
    public class UsuarioVaiTerUmaCalculadoraParaEfetuarSomaSteps
    {
        private static Application app;
        private static Window window;

        public UsuarioVaiTerUmaCalculadoraParaEfetuarSomaSteps()
        {
            app = Application.Launch(@"D:\projetos\git\BDD-WindowsForms\src\WindowsFormsApp\WindowsFormsApp\bin\Debug\WindowsFormsApp.exe");
        }

        [Given(@"que o usuário esteja na aplicação")]
        public void DadoQueOUsuarioEstejaNaAplicacao()
        {
            window = app.GetWindows()[0];

            Assert.Equal("Aplicação de Teste", window.Title);
        }

        [Given(@"informe no primeiro campo o valor (.*)")]
        public void DadoInformeNoPrimeiroCampoOValor(string p0)
        {
            var textBox1 = window.Get<TextBox>("textBox1");

            textBox1.Text = p0;
        }

        [Given(@"informe no segundo campo o valor (.*)")]
        public void DadoInformeNoSegundoCampoOValor(string p0)
        {
            var textBox2 = window.Get<TextBox>("textBox2");

            textBox2.Text = p0;
        }
        
        [When(@"clicar em somar")]
        public void QuandoClicarEmSomar()
        {
            window.Get<Button>("button1").Click();
        }
        
        [Then(@"vai ter como resultado (.*)")]
        public void EntaoVaiTerComoResultado(string p0)
        {
            var label = window.Get<Label>("lblResultado");

            Assert.Equal(p0, label.Text);
        }        
        

        [Then(@"vai ter um alerta com o seguinte texto ""(.*)""")]
        public void EntaoVaiTerUmAlertaComOSeguinteTexto(string p0)
        {
            var messageBox = window.MessageBox("Atenção");

            var texto = messageBox.Get<Label>();

            Assert.Equal(p0, texto.Text);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            if (app != null)
                app.Close();
        }
    }
}
