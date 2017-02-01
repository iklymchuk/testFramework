using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestApplication.Pages;
using TestFramework.Base;

namespace TestApplication
{
    [TestClass]
    public class UnitTest1
    {
        private const string URL = "localhost:3333";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(URL);

            // _driver = new FirefoxDriver();
            // _driver.Navigate().GoToUrl(URL);

            Login();
        }

        public void Login()
        {
            /*
             * Shouldn't use driver instanse for each Page.
             * It will be set use BasePage constructor (DriverContext approach)
             * 
             * StartPage page = new StartPage(DriverContext.Driver);
             */

            StartPage page = new StartPage();
            page.linkLogin.Click();
        }
    }
}
