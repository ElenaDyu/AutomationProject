using System;
using AutomationProject.Assembly;
using AutomationProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    [TestFixture]
    public class HomePageMinus417 : TestBase
    {
        [Test]
        public void HomePageminus417_SeeAllHeaderItems()
        {
            var home = new HomePage();
            home.SeeAllHeaderItems();

        }
    }
}
