using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public abstract class PageBase
    {
        protected IWebDriver _driver;
        public PageBase(IWebDriver driver)
        {
            if (driver == null)
                throw new ArgumentNullException("Failed to Instantiate WebDriver");
            this._driver = driver;
            var webWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
        public virtual string PageName
        {
            get;
            set;
        }
        public string GetURL()
        {
            return string.Empty;
        }
    }
}
