using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProject.Pages
{
    public class Items
    {
        public string soap = "сапун";
        public IWebElement SearchInput => Browsers.GetDriver.FindElement(By.XPath("//input[@placeholder='Търсене ...']"));
        public IWebElement SoapProduct => Browsers.GetDriver.FindElement(By.LinkText("-417 Дълбоко почистващ сапун за лице и тяло"));
        public IWebElement SoapTitle => Browsers.GetDriver.FindElement(By.XPath("//h3[.='-417 Дълбоко почистващ сапун за лице и тяло']"));
        public void SearchForProduct()
        {
            var page = new HomePage();
            page.Search.Click();
            Wait.ForReady();
            I.FillField(SearchInput, soap);
            var wait = new WebDriverWait(Browsers.GetDriver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("-417 Дълбоко почистващ сапун за лице и тяло")));   
            Wait.IsElementVisible(SoapProduct);
        }

        public void SelectProduct()
        {
            I.Click(SoapProduct);
            var wait = new WebDriverWait(Browsers.GetDriver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h3[.='-417 Дълбоко почистващ сапун за лице и тяло']")));
            Wait.IsElementVisible(SoapTitle);
        }
    }
}
