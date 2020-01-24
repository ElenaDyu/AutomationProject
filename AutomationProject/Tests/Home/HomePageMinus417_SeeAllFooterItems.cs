using AutomationProject.Assembly;
using AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Tests.Home
{
    [TestFixture]
    public class HomePageMinus417_SeeAllFooterItems : TestBase
    {
        [Test]
        public void HomePageMinus417_SeeAllFooterItems_Test()
        {
            var home = new HomePage();
            home.SeeAllFooterItems();
        }
    }
}
