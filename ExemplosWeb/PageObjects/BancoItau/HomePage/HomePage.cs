using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExemplosWeb.PageObjects.BancoItau.HomePage
{
    public class HomePage : Hooks
    {
        public static By BotaoAbrirUmaConta = By.XPath("//button[./span[text()='Anotações']]");
        public static By BotaoContaCorrente = By.XPath("//button[@aria-label='Criar']");
    }
}
