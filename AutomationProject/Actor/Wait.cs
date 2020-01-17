using AutomationProject.Assembly;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationProject.Actor
{
    public class Wait
    {
        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static void ForReady()
        {
            while (true)
            {
                var ajaxIsComplete =
                    (bool)Browsers.JavaScript.ExecuteScript("return (jQuery.active === 0) && (document.readyState === 'complete')");

                if (ajaxIsComplete)
                {
                    break;
                }
            }
        }
    }
}
