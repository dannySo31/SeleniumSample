using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC.Dynasty.AutomatedTest.Web.Page_Objects
{
    public static class PageHelper
    {
        internal static PurchaseStep2 GoToPurchaseStep2(string CANDIDATE_USERNAME, string CANDIDATE_PASSWORD, OpenQA.Selenium.IWebDriver _webDriver)
        {
            var login = new LoginPage(_webDriver);
            login.EnterCandidatePassword(CANDIDATE_PASSWORD);
            login.EnterCandidateUserName(CANDIDATE_USERNAME);
            var landing=login.LoginCandidate();

            var purchaseStep1= landing.ClickFirstItem();

            purchaseStep1.TickAliasesAndOtherNamesCheckBox();
            return purchaseStep1.GoToNextPage();
        }
    }
}
