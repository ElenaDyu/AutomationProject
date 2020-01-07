using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.Actor
{
    public static class I
    {
        public static void Click(this IWebElement element)
        {
            element.Click();
        }
    }
}
