using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests
{
    public class SeleniumDemoqa
    {
        [TestCase("ErikaB", "test", "Kaunas", "Lithuania")]
        public void TextBoxFormFourInputField(string valueFullName, string valueEmail, string valueCurrentAddress, string valuePermanentAddress, string expectedResult)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            IWebElement output = driver.FindElement(By.XPath("//*[@id=\"output\"]/div"));

            inputFullName.SendKeys(valueFullName);
            inputEmail.SendKeys(valueEmail);
            inputCurrentAddress.SendKeys(valueCurrentAddress);
            inputPermanentAddress.SendKeys(valuePermanentAddress);
            buttonSubmit.Click();
            string actualResult = output.Text;

            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

