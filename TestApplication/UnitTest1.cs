using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestApplication.Pages;

namespace TestApplication
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;
        private const string URL = "localhost:3333";

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(URL);

            Login();
        }

        public void Login()
        {
            StartPage page = new StartPage(_driver);
            page.linkLogin.Click();
        }
    }
}
