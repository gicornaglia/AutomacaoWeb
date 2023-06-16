using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemplosWeb.PageObjects.BancoItau.HomePage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExemplosWeb.Steps.BancoItau
{
    public class CadastroSteps : Hooks
    {
        public static void ValidarObrigatoriedadeDoCampoNome(string Cpf)
        {
            AbriSiteSteps.AbriSiteItau();
            AcessaFormulario();
            Report.LogMessage("Digita CPF.");
            Driver.FindElement(CadastroPage.CampoCpf).SendKeys(Cpf);
            Report.LogMessage("Digita RG");
            Driver.FindElement(CadastroPage.CampoRg).SendKeys("49632565");
            Report.LogMessage("Digita Endereço");
            Driver.FindElement(CadastroPage.CampoEndereco).SendKeys("Rua Barão de tramandai 498");
            Report.LogMessage("Digita CEP.");
            Driver.FindElement(CadastroPage.CampoCep).SendKeys("03207896");
            Report.LogMessage("Digita Telefone.");
            Driver.FindElement(CadastroPage.CampoTelefone).SendKeys("11979653265");
            Report.LogMessage("Digita Data Nascimento.");
            Driver.FindElement(CadastroPage.CampoDataNasc).SendKeys("11071990");
            Report.LogMessage("Digita Email");
            Driver.FindElement(CadastroPage.CampoEmail).SendKeys("julia.silva01@gmail.com");
            string MensagemCorreta = "Campo Nome Obrigatório";
            //Validação
            Report.LogMessage("Valida se é exibido alerta que campo Nome Obrigatório");
            Assert.IsTrue(Driver.FindElement(CadastroPage.AlertaNomeInvalido).Displayed);

            Report.LogMessage("Valida texto do alerta");
            string Mensagem = Convert.ToString(Driver.FindElement(CadastroPage.AlertaNomeInvalido).Text);
            Assert.AreEqual(Mensagem, MensagemCorreta);

            #region EXEMPLOS 
            //string TextoColuna = Driver.FindElement(ClienteComBloqueioPage.ColunaCobRobotizada).GetAttribute("Name").ToString();

            Report.LogMessage("Valida Conteúdo da mensagem");
            String CampoSituacao = Driver.FindElement(CadastroPage.AlertaCpfInvalido).GetAttribute("Value");
            Thread.Sleep(2000);

            if (CampoSituacao == "F")
            {
                Report.LogMessage("Validar Situação finalizada");
                Assert.IsTrue(Driver.FindElement(CadastroPage.AlertaCpfInvalido).Displayed);
            }
            if (CampoSituacao == "P")
            {
                Report.LogMessage("Validar Situação Pendente");
                Assert.IsTrue(Driver.FindElement(CadastroPage.AlertaCpfInvalido).Displayed);
            }
            #endregion EXEMPLOS 
        }

        private static void AcessaFormulario()
        {
            Report.LogMessage("Clica botão abrir um conta dentro da home");
            Driver.FindElement(HomePage.BotaoAbrirUmaConta).Click();
            Thread.Sleep(2000);
            Report.LogMessage("Clica botão abrir um conta Corrente");
            Driver.FindElement(HomePage.BotaoContaCorrente).Click();
            Thread.Sleep(2000);

        }
    }
}
