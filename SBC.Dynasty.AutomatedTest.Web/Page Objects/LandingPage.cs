using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public class LandingPage : PageBase
    {
        public LandingPage(IWebDriver driver)
            : base(driver)
        {
           
        }

        public override string PageName
        {
            get
            {
                return "Landing.aspx";
            }
            set
            {

            }
        }

        internal PurchaseStep1 ClickFirstItem()
        {
            var button= _driver.FindElement(By.Name("ctl00$ContentContainer$gridChecks$ctl02$LnkResult"));

            button.Click();

            return new PurchaseStep1(_driver);
        }
    }
}
