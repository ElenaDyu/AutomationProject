using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutomationProject.Actor;
using OpenQA.Selenium;
using AutomationProject.Assembly;
using OpenQA.Selenium.Interactions;
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
        public IWebElement BodyCategory => Browsers.GetDriver.FindElement(By.XPath("//span[.='Тяло']"));
        public IWebElement HandsCategory => Browsers.GetDriver.FindElement(By.XPath("//span[.='Ръце']"));
        public IWebElement FaceCategory => Browsers.GetDriver.FindElement(By.XPath("//span[.='Лице']"));
        public IWebElement LegsCategory => Browsers.GetDriver.FindElement(By.XPath("//span[.='Крака']"));
        public IWebElement HairCategory => Browsers.GetDriver.FindElement(By.XPath("//span[.='Коса']"));
        public IWebElement ShowerGel => Browsers.GetDriver.FindElement(By.XPath("//span[.='Душ гел']"));
        public IWebElement Cream => Browsers.GetDriver.FindElement(By.XPath("//span[.='Крем']"));
        public IWebElement BodyLotion => Browsers.GetDriver.FindElement(By.XPath("//span[.='Лосион за тяло']"));
        public IWebElement Butter => Browsers.GetDriver.FindElement(By.XPath("//span[.='Масло']"));
        public IWebElement Soap => Browsers.GetDriver.FindElement(By.XPath("//span[.='Сапун']"));
        public IWebElement Scrub => Browsers.GetDriver.FindElement(By.XPath("//span[.='Скраб']"));
        public IWebElement Salts => Browsers.GetDriver.FindElement(By.XPath("//span[.='Соли']"));
        public IWebElement HandsCream => Browsers.GetDriver.FindElement(By.XPath("//li[@id='nav-menu-item-4566']//span"));
        public IWebElement HandsSoap => Browsers.GetDriver.FindElement(By.XPath("//li[@id='nav-menu-item-4567']//span"));
        public IWebElement Gel => Browsers.GetDriver.FindElement(By.XPath("//span[.='Гел']"));
        public IWebElement FaceCream => Browsers.GetDriver.FindElement(By.XPath("//li[@id='nav-menu-item-4570']//span"));
        public IWebElement Mask => Browsers.GetDriver.FindElement(By.XPath("//span[.='Маска']"));
        public IWebElement CleanUp => Browsers.GetDriver.FindElement(By.XPath("//span[.='Почистване']"));
        public IWebElement Serum => Browsers.GetDriver.FindElement(By.XPath("//span[.='Серум']"));
        public IWebElement Tonic => Browsers.GetDriver.FindElement(By.XPath("//span[.='Тоник']"));
        public IWebElement LegsCream => Browsers.GetDriver.FindElement(By.XPath("//a[@href='https://minus417.bg/produkt-category/kraka/krem-kraka/']//span"));
        public IWebElement HairCare => Browsers.GetDriver.FindElement(By.XPath("//span[.='Грижа за косата']"));
        public IWebElement SeriesForMan => Browsers.GetDriver.FindElement(By.XPath("//span[.='Серия за мъже']"));
        public IWebElement SensualEssence => Browsers.GetDriver.FindElement(By.XPath("//span[.='Sensual Essense']"));
        public IWebElement SerenityLegend => Browsers.GetDriver.FindElement(By.XPath("//span[.='Serenity Legend']"));
        public IWebElement TimeControl => Browsers.GetDriver.FindElement(By.XPath("//span[.='Time Control']"));
        public IWebElement RadiantSee => Browsers.GetDriver.FindElement(By.XPath("//span[.='Radiant See']"));
        public IWebElement ReDefine => Browsers.GetDriver.FindElement(By.XPath("//span[.='Re Define']"));
        public IWebElement InfiniteMotion => Browsers.GetDriver.FindElement(By.XPath("//span[.='Infinite Motion']"));
        public IWebElement EvenMore => Browsers.GetDriver.FindElement(By.XPath("//span[.='Even More']"));
        public IWebElement AbsoluteMud => Browsers.GetDriver.FindElement(By.XPath("//span[.='Absolute mud']"));
       // public IWebElement  => Browsers.GetDriver.FindElement(By.XPath("//span[.='']"));
       // public IWebElement  => Browsers.GetDriver.FindElement(By.XPath("//span[.='']"));

        public void SeeAllHeaderItems()
        {
           
            Wait.IsElementVisible(StartTab);
            //Wait.IsElementVisible(SpecialOffersTab);
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

        public void SeeAllCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(BodyCategory);
            Wait.IsElementVisible(HandsCategory);
            Wait.IsElementVisible(FaceCategory);
            Wait.IsElementVisible(LegsCategory);
            Wait.IsElementVisible(HairCategory);
        }

        public void SeeAllBodySubCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(BodyCategory);
            builder.MoveToElement(BodyCategory).Perform();
            Wait.IsElementVisible(ShowerGel);
            Wait.IsElementVisible(Cream);
            Wait.IsElementVisible(BodyLotion);
            Wait.IsElementVisible(Butter);
            Wait.IsElementVisible(Soap);
            Wait.IsElementVisible(Scrub);
            Wait.IsElementVisible(Salts);
        }

        public void SeeAllHandsSubCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(HandsCategory);
            builder.MoveToElement(HandsCategory).Perform();
            Wait.IsElementVisible(HandsCream);
            Wait.IsElementVisible(HandsSoap);
        }

        public void SeeAllFaceSubCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(FaceCategory);
            builder.MoveToElement(FaceCategory).Perform();
            Wait.IsElementVisible(Gel);
            Wait.IsElementVisible(FaceCream);
            Wait.IsElementVisible(Mask);
            Wait.IsElementVisible(CleanUp);
            Wait.IsElementVisible(Serum);
            Wait.IsElementVisible(Tonic);
        }

        public void SeeAllLegsSubCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(LegsCategory);
            builder.MoveToElement(LegsCategory).Perform();
            Wait.IsElementVisible(LegsCream);
        }

        public void SeeAllHairSubCategories()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(CategoriesTab).Perform();
            Wait.IsElementVisible(HairCategory);
            builder.MoveToElement(HairCategory).Perform();
            Wait.IsElementVisible(HairCare);
        }

        public void SeeAllSeries()
        {
            Actions builder = new Actions(Browsers.GetDriver);
            builder.MoveToElement(SeriesTab).Perform();
            Wait.IsElementVisible(SeriesForMan);
            Wait.IsElementVisible(SensualEssence);
            Wait.IsElementVisible(SerenityLegend);
            Wait.IsElementVisible(TimeControl);
            Wait.IsElementVisible(RadiantSee);
            Wait.IsElementVisible(ReDefine);
            Wait.IsElementVisible(InfiniteMotion);
            Wait.IsElementVisible(EvenMore);
            Wait.IsElementVisible(AbsoluteMud);
        }
    }
}
