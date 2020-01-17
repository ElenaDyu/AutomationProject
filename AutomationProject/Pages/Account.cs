using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;

namespace AutomationProject.Pages
{
   public class Account
    {
        public IWebElement EmailAddress => Browsers.GetDriver.FindElement(By.CssSelector("#username"));
        public IWebElement Entrance => Browsers.GetDriver.FindElement(By.XPath("//button[@name='login']"));
        public IWebElement Errormessage => Browsers.GetDriver.FindElement(By.XPath("//li[@class='uk-flex uk-flex-middle']"));
            public void GoToMyProfile()
        {
            var profile = new HomePage();
            I.Click(profile.MyProfile);
            Wait.ForReady();
        }

        public void CheckValidation()
        {
            var FakeData = new FakerClass();
            I.FillField(EmailAddress, FakeData.FakeEmailAddress);
            I.Click(Entrance);
            Wait.IsElementVisible(Errormessage);
            I.Wait(4);
        }
    }
}
