using System;
using AutomationProject.Assembly;
using AutomationProject.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    [TestFixture]
    public class GreenTea : TestBase
    {
        [Test]
        public void GreenTea_AddEditOrder()
        {
            var demo = new Теаs();

            demo.SelectMenuSection();
            demo.PayWithCreditCardGreenTea();
        }
    }
}
