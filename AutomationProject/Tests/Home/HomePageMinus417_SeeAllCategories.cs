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
    public class HomePageMinus417_SeeAllCategories : TestBase
    {
        [Test]
        public void HomePageminus417_SeeAllCategories_Test()
        {
            var home = new HomePage();
            home.SeeAllCategories();

        }

    }
}
