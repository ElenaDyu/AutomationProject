using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;

namespace AutomationProject.Pages
{
   public class Account
    {
        public string Pass = "A*M54ONempw5";
        public string email = "edyulgerska@gmail.com";

        public IWebElement EmailAddress => Browsers.GetDriver.FindElement(By.CssSelector("#username"));
        public IWebElement Entrance => Browsers.GetDriver.FindElement(By.XPath("//button[@name='login']"));
        public IWebElement Errormessage => Browsers.GetDriver.FindElement(By.XPath("//li[@class='uk-flex uk-flex-middle']"));
        public IWebElement Password => Browsers.GetDriver.FindElement(By.Id("password"));
        public IWebElement MyProfileTitle => Browsers.GetDriver.FindElement(By.XPath("//h1[.='Моят профил']"));
        public IWebElement Scoreboard => Browsers.GetDriver.FindElement(By.XPath("//div[@id='post-303']//a[@href='https://minus417.bg/my-profile/']"));
        public IWebElement Orders => Browsers.GetDriver.FindElement(By.XPath("//div[@id='post-303']//a[@href='https://minus417.bg/my-profile/orders/']"));
        public IWebElement Downloads => Browsers.GetDriver.FindElement(By.XPath("//div[@id='post-303']//a[@href='https://minus417.bg/my-profile/downloads/']"));
        public IWebElement Addresses => Browsers.GetDriver.FindElement(By.XPath("//div[@id='post-303']//a[@href='https://minus417.bg/my-profile/edit-address/']"));
        public IWebElement ProfileDetails => Browsers.GetDriver.FindElement(By.XPath("//div[@id='post-303']//a[@href='https://minus417.bg/my-profile/edit-account/']"));

        public void GoToMyProfile()
        {
            var profile = new HomePage();
            I.Click(profile.MyProfile);
            I.Wait(2);
        }

        public void CheckValidation()
        {
            var FakeData = new FakerClass();
            I.FillField(EmailAddress, FakeData.FakeEmailAddress);
            I.Click(Entrance);
            Wait.ForReady();
            Wait.IsElementVisible(Errormessage);
            I.FillField(Password,Pass);
            I.Click(Entrance);
            Wait.ForReady();
            Wait.IsElementVisible(Errormessage);
        }

        public void LogInWithValidatedEmail()
        {
            I.FillField(EmailAddress, email);
            I.FillField(Password, Pass);
            I.Click(Entrance);
            Wait.ForReady();
        }

        public void SeeMyProfilePageItems()
        {
            Wait.IsElementVisible(MyProfileTitle);
            Wait.IsElementVisible(Scoreboard);
            Wait.IsElementVisible(Orders);
            Wait.IsElementVisible(Downloads);
            Wait.IsElementVisible(Addresses);
            Wait.IsElementVisible(ProfileDetails);
        }

    }
}
