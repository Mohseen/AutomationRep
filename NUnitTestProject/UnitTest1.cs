using System;
using System.Text;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace NUnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new FirefoxDriver();

        }
        [TearDown]
        public void Tear()
        {
            _driver.Close();
        }
        [Test]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("http://google.com");
            _driver.FindElement(By.Id("gbqfq")).SendKeys("Selenium");
            _driver.FindElement(By.Id("gbqfb")).Click();
            
            string title = _driver.Title;


            Assert.AreEqual("Google", title);

            
        }
    }
}
