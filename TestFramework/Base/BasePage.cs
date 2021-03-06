﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Base
{
    public abstract class BasePage : Base
    {
        /*
         * Change to DriverContex approach
         * 
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        */

        private IWebDriver _driver { get; set; }

        //DriverContext approuch
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            PageFactory.InitElements(DriverContext.Driver, pageInstance);

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
