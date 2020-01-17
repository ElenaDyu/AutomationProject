using AutomationProject.Actor;
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
     public class RegistrationForm_Validation : TestBase
    {
        [Test]
        public void RegistrationForm_Validation_Test()
        {
            var account = new Account();
            account.GoToMyProfile();
            account.CheckValidation();

        }

    }
}
