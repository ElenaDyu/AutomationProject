using System;
using AutomationProject.Assembly;
using AutomationProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Tests
{
    [TestFixture]
    public class HomePageMinus417_SeeAllHeaderItems : TestBase
    {
        [Test]
        public void HomePageMinus417_SeeAllHeaderItems_Test()
        {
            var home = new HomePage();
            var profile = new Account();
            home.SeeAllHeaderItems();
            profile.GoToMyProfile();
            
        }
    }
}
