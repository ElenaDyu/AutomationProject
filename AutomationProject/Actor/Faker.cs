using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;

namespace AutomationProject.Actor
{
    public class FakerClass
    {
        public string FakeEmailAddress = Internet.Email();
    }
}
