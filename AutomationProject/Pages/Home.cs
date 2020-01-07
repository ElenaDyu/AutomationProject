using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;

namespace AutomationProject.Pages
{
    public class Home
    {
        //These are the locators
        public IWebElement MenuItem => Assembly.Browsers.getDriver.FindElement(By.XPath("//a[contains(.,'Menu')]"));

        //these are the actions 
        public void SelectMenuSection()
        {
            I.Click(MenuItem);
            Thread.Sleep(5);
        }

    }

}
