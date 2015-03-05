using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public class LoginPage:PageBase
    {
        protected string landingPage = "http://localhost:1888/Web/Public/Login.aspx";
        public LoginPage(IWebDriver driver): base(driver)
        {

            _driver.Navigate().GoToUrl(landingPage);
           
           
        }

        internal void EnterCandidateUserName(string candidateUserName)
        {
            EnterText(candidateUserName, "ctl00$ContentContainer$ucLoginBox$TxtUserName");
        }

        private void EnterText(string text, string element)
        {
            var a = _driver.FindElement(By.Name(element));
            a.SendKeys(text);
        }

        internal void EnterCandidatePassword(string candidatePassword)
        {
            EnterText(candidatePassword, "ctl00$ContentContainer$ucLoginBox$TxtPassword");
           
        }

        public LandingPage  LoginCandidate()
        {
            var login = _driver.FindElement(By.Id("ctl00_ContentContainer_ucLoginBox_BtnSubmit"));
            login.Click();

            return new LandingPage(_driver);
        }
    }
}
