using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace ExemplosWeb.Steps.BancoItau
{
    public class AbriSiteSteps : Hooks
    {
        private static ChromeDriver ChromeDriver;
        public static void AbriSiteItau()
        {
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "https://www.itau.com.br/";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60); //Comando para que toda vez que mudar a URL ele esperar 60 segundos
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60); // Comando para toda esperar 60 segundos para procurar o elemento e não quebrar 
            ChromeDriver.Manage().Window.Maximize();
            
        }
    }
}
