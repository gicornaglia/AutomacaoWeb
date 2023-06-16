using ExemplosWeb.Steps.BancoItau;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExemplosWeb.Features.BancoItau
{
    [TestClass]
    public class BancoItau : Hooks
    {
        [MyTestMethod]
        [TestCategory("CT133059")]
        [TestCategory("US131876")]
        [DynamicData(nameof(RetornaInformacoes), DynamicDataSourceType.Method)]
        public void ValidarObrigatoriedadeDoCampoNome(String Cpf)
        {
            Report.LogMessage("Dado que: O usuário acesse o site Itau");
            Report.LogMessage("E: queira se criar uma conta ");
            Report.LogMessage("E: clique no botão criar uma conta");
            Report.LogMessage("E: preencha todos os campos corretamente deixando o campo nome em branco ");
            Report.LogMessage("Quando: clicar em finalizar ");
            Report.LogMessage("Então: o sistema mostrará que o campo nome precisa ser preenchido  ");
            Report.LogMessage("");

            CadastroSteps.ValidarObrigatoriedadeDoCampoNome(Cpf);
        }


        #region MASSA DE DADOS
        public static IEnumerable<object[]> RetornaInformacoes()
        {
            string Cpf = "21306932560";
            string codigoCobrancaRobotizada = "21";

            yield return new[] { Cpf,codigoCobrancaRobotizada };

        }
        // se quiser add o banco de dados: 
        private static IEnumerable<object[]> BuscaData()
        {
            //string connectionString = JObject.Parse(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Deploy", "Oracle.json"))).SelectToken("COM_SPR_HO").ToString();
            //string queeryString = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQL/Movimentos/AutomatizacaoDeCobranca/Programacao/Diária", "BuscaData.sql"));
            //var result = MyOracleDataReader(queeryString, connectionString);

            string CodigoCodRob = "21-Cobrança Robotizada";
            //foreach (var item in result)
            {
                yield return new[] { CodigoCodRob }; //item[2].Value
            }
            //CRIO A PASTA SQL PARA COLOCA A QUERY E CRIO DENTRO DA DEPLOY ORACLE.JSON
        }

        #endregion MASSA DE DADOS
    }
}
