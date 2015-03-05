using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public class PurchaseStep2: PageBase
    {
        public PurchaseStep2(IWebDriver driver)
            : base(driver)
        {
        }



        internal void EnterYearText(string text)
        {
            var textBox= _driver.FindElement(By.Name("ctl00$ContentContainer$ucDateControl$txtYear"));
            textBox.SendKeys(text);
            textBox.SendKeys(OpenQA.Selenium.Keys.Tab);
         
        }

        public string ErrorMessageYearText
        {
            get
            {
                var span= _driver.FindElement(By.Id("ctl00_ContentContainer_ucDateControl_CustomYearValidator"));
                return span.Text;
            }
            
            }
    }
}
