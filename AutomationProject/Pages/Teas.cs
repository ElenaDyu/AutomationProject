using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Pages
{
    public class Теаs
    {
        public string number = "111222333";
        public string firstname = "elena";
        public string email = "testmest@mailinator.com";
        public string mainstreet = "1st street";
        public string code = "1234567";

        public IWebElement MenuItem => Assembly.Browsers.getDriver.FindElement(By.XPath("//a[contains(.,'Menu')]"));
        public IWebElement CheckOut => Assembly.Browsers.getDriver.FindElement(By.Id("wsb-button-00000000-0000-0000-0000-000451955160"));
        public IWebElement EmailAddress => Assembly.Browsers.getDriver.FindElement(By.Id("email"));
        public IWebElement Name => Assembly.Browsers.getDriver.FindElement(By.Id("name"));
        public IWebElement Address => Assembly.Browsers.getDriver.FindElement(By.Id("address"));
        public IWebElement CardType => Assembly.Browsers.getDriver.FindElement(By.Id("card_type"));
        public IWebElement CardNumber => Assembly.Browsers.getDriver.FindElement(By.Id("card_number"));
        public IWebElement CardHolderName => Assembly.Browsers.getDriver.FindElement(By.Id("cardholder_name"));
        public IWebElement VerificationCard => Assembly.Browsers.getDriver.FindElement(By.Id("verification_code"));
        public IWebElement PlaceOrderButton => Assembly.Browsers.getDriver.FindElement(By.XPath("//button[@class='btn btn-primary']"));

        public void SelectMenuSection()
        {
            I.Click(MenuItem);
            Thread.Sleep(2);
        }

        public void PayWithCreditCardGreenTea()
        {
            I.Click(CheckOut);
            I.FillField(EmailAddress,email);
            I.FillField(Name, firstname);
            I.FillField(Address, mainstreet);
            SelectElement cardtypedropdown = new SelectElement(CardType);
            cardtypedropdown.SelectByIndex(2);
            I.FillField(CardNumber,code);
            I.FillField(CardHolderName, firstname);
            I.FillField(VerificationCard, code);
            I.Wait(2);
            I.Click(PlaceOrderButton);
        }
    }
}
