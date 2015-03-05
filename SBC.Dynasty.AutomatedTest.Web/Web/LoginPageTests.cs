using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SBC.Dynasty.AutomatedTest.Web.Page_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Spec.NUnit;
using OpenQA.Selenium.Support.UI;

namespace SBC.Dynasty.AutomatedTest.Web.Web
{
    public class when_logging_in:Specification
    {
        
        protected const string CANDIDATE_USERNAME = "dso3123";
        protected const string CANDIDATE_PASSWORD = "NewPassword31";
        protected IWebDriver _webDriver;
        protected LoginPage _loginPage;
        protected override void Establish_context()
        {
            base.Establish_context();
            _webDriver = new ChromeDriver();
           

        }
        [TearDown]
        protected void CleanUp()
        {
            System.Threading.Thread.Sleep(5000);
           
            _webDriver.Quit();
        }
        public class and_entering_an_invalid_year_in_purchase2_page :
           when_logging_in
        {
            PurchaseStep2 page;
            protected override void Establish_context()
            {
                base.Establish_context();
                page=PageHelper.GoToPurchaseStep2(CANDIDATE_USERNAME, CANDIDATE_PASSWORD, _webDriver);
                
            }

            protected override void Because_of()
            {
                base.Because_of();
                page.EnterYearText("192");
                

            }

            [Test]

            public void then_there_will_be_an_error_message()
            {
                page.ErrorMessageYearText.ShouldNotEqual(string.Empty);
            }
        }
        public class and_supplying_candidate_username_and_password :
            when_logging_in
        {
            string expected="Landing.aspx";
            string actual = string.Empty;
            protected override void Establish_context()
            {
                base.Establish_context();
               
                _loginPage = new LoginPage(_webDriver);
                
                _loginPage.EnterCandidateUserName(CANDIDATE_USERNAME);
                _loginPage.EnterCandidatePassword(CANDIDATE_PASSWORD);
                
                
                
            }
            protected override void Because_of()
            {
                base.Because_of();
                var landing=_loginPage.LoginCandidate();

                expected = landing.GetURL();
            }

            [Test]
            public void then_login_success()
            {
                actual.ShouldContain(expected);
            }
           
        }
        


    }
}
