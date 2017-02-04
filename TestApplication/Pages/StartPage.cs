using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Base;

namespace TestApplication.Pages
{
    class StartPage : BasePage
    {

        /*
         * The BasePage child doesn't need constructor anymore
         * It will be use default BasePage constructor (with DriverContext approach) 
         * 
        public StartPage(IWebDriver driver) : base(driver)
        { 
        }
        */

        [FindsBy(How = How.LinkText, Using = "Log in")]
        IWebElement linkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "Username")]
        IWebElement textUsername { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement textPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        IWebElement buttonLogin { get; set; }

        public HomePage Login (string username, string password)
        {
            linkLogin.SendKeys(username);
            textUsername.SendKeys(password);
            buttonLogin.Submit();

            //return new HomePage();

            //POM with generic approuch
            return GetInstance<HomePage>();
        }
    }
}
