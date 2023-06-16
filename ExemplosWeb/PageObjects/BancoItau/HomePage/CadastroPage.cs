using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExemplosWeb.PageObjects.BancoItau.HomePage
{
    public class CadastroPage
    {
        #region FORMULARIO De Cadastro
        public static By CampoNome = By.XPath("//button[./span[text()='Anotações']]");
        public static By CampoCpf = By.XPath("//button[@aria-label='Criar']");
        public static By CampoRg = By.XPath("//div[@role='dialog']//p[text()='Campo obrigatório']");
        public static By CampoEndereco = By.XPath("//div[@role='progressbar']");
        public static By CampoCep = By.XPath("//div[@role='dialog']//p[text()='Campo obrigatório']");
        public static By CampoTelefone = By.XPath("//div[@role='progressbar']");
        public static By CampoDataNasc = By.XPath("//div[@role='dialog']//p[text()='Campo obrigatório']");
        public static By CampoEmail = By.XPath("//div[@role='progressbar']");
        public static By AlertaNomeInvalido = By.XPath("//div[@role='progressbar']");
        public static By AlertaCpfInvalido = By.XPath("//div[@role='progressbar']");
        public static By AlertaRgInvalido = By.XPath("//div[@role='progressbar']");


        #endregion fORMULARIO 

    }
}
