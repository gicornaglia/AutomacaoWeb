using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExemplosWeb.Features.BancoItau
{
    [TestClass]
    public class BancoItauPage : Hooks
    {
        [MyTestMethod]
        [TestCategory("CT133059")]
        [TestCategory("US131876")]
        public void ValidarCampoPeriodoComInformacoesValidas(string CodigoCodRob, string data)
        {
            Report.LogMessage("Dado que: O usuário está logado");
            Report.LogMessage("E: acesso o menu 'Movimentos/ 3. automatização de cobrança/ 1. Programação/ 1. Diária'");
            Report.LogMessage("E: escolho uma opção no campo @AcaoDeCobranca ");
            Report.LogMessage("E: no campo @Periodo escolho um período válido ");
            Report.LogMessage("Quando: clico no botão [Consultar] ");
            Report.LogMessage("Então: o sistema mostrará informações corretas  ");
            Report.LogMessage("");

            //DiariaSteps.ValidarCampoPeriodoComInformacoesValidas(CodigoCodRob, data);
        }
    }
}
