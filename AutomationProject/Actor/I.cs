using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationProject.Assembly;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Actor
{
    public static class I
    {
        public static TimeSpan waitForElement = TimeSpan.FromSeconds(10);

        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        public static void FillField(this IWebElement element, string input)
        {
            element.SendKeys(input);
        }

        public static void Wait(int seconds)
        {
            Thread.Sleep((int)TimeSpan.FromSeconds(seconds).TotalMilliseconds);
        }

    }
}
