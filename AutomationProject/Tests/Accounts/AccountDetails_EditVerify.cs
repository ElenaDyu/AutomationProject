using AutomationProject.Assembly;
using AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Tests.Accounts
{
    [TestFixture]
    public class ProfileDetails_EditVerify : TestBase
    {
        [Test]
        public void ProfileDetails_EditVerify_Test()
        {
            var account = new Account();
            account.GoToMyProfile();
            account.LogInWithValidatedEmail();
            account.SeeMyProfilePageItems();
            account.GoToProfileDetails();
        }
    }
}
