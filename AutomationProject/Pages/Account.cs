using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationProject.Pages
{
   public class Account
    {
        public string Pass = "ElenaDyulgerska2193";
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
        public IWebElement Exit => Browsers.GetDriver.FindElement(By.XPath("//li[contains(@class,'woocommerce-MyAccount-navigation-link woocommerce-MyAccount-navigation-link--customer-logout')]//a[contains(@class,'uk-h5 uk-link')]"));
        public IWebElement EntranceLabel => Browsers.GetDriver.FindElement(By.XPath("//div[@class='u-column1 col-1 uk-width-1-2@m']//h2"));
        public IWebElement ProfileDetailsLabel => Browsers.GetDriver.FindElement(By.XPath("//h1[.='Детайли на профила']"));
        public IWebElement FirstName => Browsers.GetDriver.FindElement(By.Id("account_first_name"));
        public IWebElement LastName => Browsers.GetDriver.FindElement(By.Id("account_last_name"));
        public IWebElement DisplayName => Browsers.GetDriver.FindElement(By.Id("account_display_name"));
        public IWebElement DisplayName => Browsers.GetDriver.FindElement(By.Id("account_display_name"));

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
            I.Wait(2);
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

        public void LogOutFromMyProfile()
        {
            I.Click(Exit);
            Wait.IsElementVisible(EntranceLabel);
        }

        public void GoToProfileDetails()
        {
            I.Click(ProfileDetails);
            var wait = new WebDriverWait(Browsers.GetDriver, new TimeSpan(0, 0, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h1[.='Детайли на профила']")));
        }

    }
}
