using System;
using AutomationProject.Assembly;
using AutomationProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    [TestFixture]
    public class DemoSite_Open : TestBase
    {
        [Test]
        public void DemoSite_Open_Test()
        {
            var demo = new Home();

            demo.SelectMenuSection();
        }
    }
}
