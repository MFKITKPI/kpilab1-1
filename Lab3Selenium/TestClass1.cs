﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace Lab3Selenium
{
    [TestFixture]
    class TestClass1
    {
       // Generated by Selenium IDE
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            var firefoxOptions = new FirefoxOptions
            {
                BrowserExecutableLocation = (@"C:\Program Files\Mozilla Firefox\firefox.exe")
            };
            driver = new FirefoxDriver(firefoxOptions);
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void rozetka()
        {
            driver.Navigate().GoToUrl("https://rozetka.com.ua/");
            driver.Manage().Window.Size = new System.Drawing.Size(1550, 838);
            driver.FindElement(By.Name("search")).Click();
            driver.FindElement(By.Name("search")).SendKeys("Ноутбук Asus AsusPRO P1440FA-FA1547 (90NX0211-M19930) Grey ");
            driver.FindElement(By.LinkText("Все результаты поиска →")).Click();
            driver.FindElement(By.CssSelector(".button_size_large")).Click();
            driver.FindElement(By.LinkText("Продолжить покупки")).Click();
            driver.FindElement(By.CssSelector(".header-actions__button_type_basket > svg")).Click();
            driver.FindElement(By.CssSelector(".modal__close")).Click();
            driver.Close();
        }
    }
}
