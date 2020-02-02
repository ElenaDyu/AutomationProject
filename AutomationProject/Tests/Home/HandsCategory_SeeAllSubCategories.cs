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
    public class HandsCategory_SeeAllSubCategories : TestBase
    {
        [Test]
        public void HandsCategory_SeeAllSubCategories_Test()
        {
            var home = new HomePage();
            home.SeeAllHandsSubCategories();
        }
    }
}
