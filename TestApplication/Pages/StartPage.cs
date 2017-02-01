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
        public IWebElement linkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement textUsername { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement textPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        public IWebElement buttonLogin { get; set; }
    }
}
