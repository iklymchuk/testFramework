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
    class HomePage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Profile")]
        IWebElement linkProfile { get; set; }

        public ProfilePage ClickProfilePageLink ()
        {
            linkProfile.Click();

            //return new ProfilePage();

            //POM with generic approuch
            return GetInstance<ProfilePage>();
        }
    }
}
