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
        private static IWebDriver driver;
        private static readonly string Url = "https://minus417.bg/";
        private static readonly string browser = "Chrome";
        public static IJavaScriptExecutor js;

        public static void Initialize()
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            GoTo(Url);
            Thread.Sleep(5);
        }

        public static string Title
        {
            get
            { return driver.Title; }
        }

        public static IWebDriver GetDriver
        {
            get
            { return driver; }
        }

        public static void GoTo(string url)
        {
            driver.Url = url;
        }

        public static void Close()
        {
            driver.Quit();
        }

        public static IJavaScriptExecutor JavaScript
        {
            get
            {
                return driver as IJavaScriptExecutor;
            }
        }

    }
}
