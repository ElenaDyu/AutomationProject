using AutomationProject.Assembly;
using AutomationProject.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Tests.Products
{
    [TestFixture]
    public class SoapProduct_SearchSeeOpen : TestBase 
    {
        [Test]
        public void SoapProduct_SearchSeeOpen_Test()
        {
            var items = new Items();
            items.SearchForProduct();
            items.SelectProduct();
        }
    }
}
