﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTestsWithoutPOM
{
    internal class HelloWorld
    {
        [Test]
        public void FirstChromeTest()
        {
            string expectedResult = "Google";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            string actualResult = driver.Title;
            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
