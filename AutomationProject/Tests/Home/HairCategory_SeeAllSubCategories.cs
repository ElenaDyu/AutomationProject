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
    public class HairCategory_SeeAllSubCategories : TestBase 
    {
        [Test]
        public void HairCategory_SeeAllSubCategories_Test()
        {
            var home = new HomePage();
            home.SeeAllHairSubCategories();
        }


    }
}
