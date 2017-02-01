using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Base
{
    public abstract class BasePage
    {
        /*
         * Change to DriverContex approach
         * 
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        */

        //DriverContext approuch
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }
    }
}
