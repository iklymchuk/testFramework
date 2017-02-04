using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestApplication.Pages;
using TestFramework.Base;

namespace TestApplication
{
    [TestClass]
    public class UnitTest1 : Base
    {
        private const string URL = "localhost:3333";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(URL);


            /*
             * Update POM without Generics
             * 
            StartPage startPage = new StartPage();
            HomePage homePage = startPage.Login("user", "password");
            ProfilePage profilePage = homePage.ClickProfilePageLink();
            */

            /*
            * POM without Generics
           StartPage startPage = new StartPage();
           CurrentPage = startPage.Login("user", "password");
           ((HomePage)CurrentPage).ClickProfilePageLink();
           */

            //POM with Generics
            CurrentPage = GetInstance<StartPage>();
            //CurrentPage.As<StartPage>(). - other methods on the StartPage

            //Change the current page - now it is HomePage
            CurrentPage = CurrentPage.As<StartPage>().Login("user", "password");
            //CurrentPage.As<HomePage>(). - other methods on the HomePage

            //Change the current page - now it is profilePage
            CurrentPage = CurrentPage.As<HomePage>().ClickProfilePageLink();
        }

    }
}
