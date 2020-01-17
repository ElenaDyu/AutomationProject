﻿using System;
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
    public class HomePage
    {
        public IWebElement StartTab => Browsers.GetDriver.FindElement(By.XPath("//span[.='Начало']"));
        public IWebElement SpecialOffersTab => Browsers.GetDriver.FindElement(By.XPath("//span[.='Специални предложения']"));
        public IWebElement ProductsTab  = Browsers.GetDriver.FindElement(By.XPath("//span[.='Продукти']"));
        public IWebElement SeriesTab = Browsers.GetDriver.FindElement(By.XPath("//span[.='Серии']"));
        public IWebElement BlogTab = Browsers.GetDriver.FindElement(By.XPath("//span[.='Блог']"));
        public IWebElement ForUsTab = Browsers.GetDriver.FindElement(By.XPath("//span[.='За нас']"));
        public IWebElement CategoriesTab = Browsers.GetDriver.FindElement(By.XPath("//span[.='Категории']"));
        public IWebElement Cart = Browsers.GetDriver.FindElement(By.XPath("//a[@title='Cart']//*[local-name()='svg']"));
        public IWebElement Search = Browsers.GetDriver.FindElement(By.XPath("//div[@class='de-header__search']//*[local-name()='svg']"));
        public IWebElement MyProfile = Browsers.GetDriver.FindElement(By.XPath("//a[@title='Моят профил']//*[local-name()='svg']"));
        public IWebElement ToTheStoreLink = Browsers.GetDriver.FindElement(By.XPath("//div[@id='header-image']//a[@href='https://minus417.bg/kozmetika/']"));
        public IWebElement Delivery => Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/dostavka/']"));
        public IWebElement ReturnOrder = Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/vryshtane-na-poruchka/']"));
        public IWebElement Cookies = Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/coockies/']"));
        public IWebElement PrivacyPolicy => Browsers.GetDriver.FindElement(By.XPath("//li[@id='menu-item-534']//a"));
        public IWebElement QuestionsAndAnswers => Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/vyprosi-i-otgovori/']"));
        public IWebElement ToContactUs => Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/za-vryzka-s-nas/']"));

        public void SeeAllHeaderItems()
        {
            Wait.IsElementVisible(StartTab);
            Wait.IsElementVisible(SpecialOffersTab);
            Wait.IsElementVisible(ProductsTab);
            Wait.IsElementVisible(SeriesTab);
            Wait.IsElementVisible(BlogTab);
            Wait.IsElementVisible(ForUsTab);
            Wait.IsElementVisible(CategoriesTab);
            Wait.IsElementVisible(Cart);
            Wait.IsElementVisible(Search);
            Wait.IsElementVisible(MyProfile);
            Wait.IsElementVisible(ToTheStoreLink);
        }

        public void SeeAllFooterItems()
        {
            Wait.IsElementVisible(Delivery);
            Wait.IsElementVisible(ReturnOrder);
            Wait.IsElementVisible(Cookies);
            Wait.IsElementVisible(PrivacyPolicy);
            Wait.IsElementVisible(QuestionsAndAnswers);
            Wait.IsElementVisible(ToContactUs);
        }

        
    }
}
