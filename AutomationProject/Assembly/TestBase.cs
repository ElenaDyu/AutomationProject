using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace AutomationProject.Assembly
{
    public class TestBase
    {
        [OneTimeSetUp]
        public static void SetUp()
        {
            Browsers.Initialize();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Browsers.Close();
        }

    }
}
