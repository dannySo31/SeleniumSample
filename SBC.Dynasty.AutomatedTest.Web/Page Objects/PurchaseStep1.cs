using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public class PurchaseStep1:PageBase
    {
        

        public PurchaseStep1(OpenQA.Selenium.IWebDriver _driver):base(_driver)
        {
          
        }

        internal void TickAliasesAndOtherNamesCheckBox()
        {
            var checkBox = _driver.FindElement(By.Name("ctl00$ContentContainer$ChkConfirmation"));
            checkBox.Click();
        }

        internal PurchaseStep2 GoToNextPage()
        {
            var button = _driver.FindElement(By.Name("ctl00$ContentContainer$BtnNextStep"));
            button.Click();

            return new PurchaseStep2(_driver);
        }
    }
}
