using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Assembly
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        private static readonly string Url = "https://minus417.bg/";
        private static readonly string browser = "Chrome";

        public static void Initialize()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "FireFox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            GoTo(Url);
            Thread.Sleep(5);
        }

        public static string Title
        {
            get
            { return webDriver.Title; }
        }

        public static IWebDriver getDriver
        {
            get
            { return webDriver; }
        }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
