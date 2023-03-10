using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumTestsWithoutPOM
{
    internal class Class1
    {
        
        [Test]
        public void LoginFormWithValidData()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@id=\"masthead\"]/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonIconUser.Click();

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "Testavimas1";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id=\"customer_login\"]/div[1]/div/form/a/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);
           
            buttonPrisijungti.Click();

            driver.Quit();
        }

        [Test]
        public void RegisterFormWithValidData()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@id=\"masthead\"]/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonIconUser.Click();

            string valueEmail = "tests@tester.com";
          
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"reg_email\"]"));
            IWebElement buttonRegistruotis = driver.FindElement(By.XPath("//*[@id=\"customer_login\"]/div[2]/div/form/p[4]/button"));

            inputEmail.SendKeys(valueEmail);

            buttonRegistruotis.Click();

            driver.Quit();

        }

        [Test]
        public void UserInformationFormUpdate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIconUser = driver.FindElement(By.XPath("//*[@id=\"masthead\"]/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonIconUser.Click();

            string valueVartotojoVardas = "erika.butkut";
            string valueSlaptazodis = "Testavimas1";

            IWebElement inputVartotojoVardas = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            IWebElement inputSlaptazodis = driver.FindElement(By.XPath("//*[@id=\"password\"]"));
            IWebElement buttonPrisijungti = driver.FindElement(By.XPath("//*[@id=\"customer_login\"]/div[1]/div/form/a/p[3]/button"));

            inputVartotojoVardas.SendKeys(valueVartotojoVardas);
            inputSlaptazodis.SendKeys(valueSlaptazodis);

            buttonPrisijungti.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 100)");

            IWebElement buttonPaskyra = driver.FindElement(By.XPath("//*[@id=\"masthead\"]/div[1]/div[4]/ul/li[3]/div/a/i"));
            buttonPaskyra.Click();

            IWebElement buttonVartotojoInformacija = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/div/div/ul/li[5]"));
            buttonVartotojoInformacija.Click();

            string valueEsamasSlaptazodis = "Testavimas1";
            string valueNaujasSlaptazodis = "Testavimas2";
       
            IWebElement inputEsamasSlaptazodis = driver.FindElement(By.XPath("//*[@id=\"password_current\"]"));
            IWebElement inputNaujasSlaptazodis = driver.FindElement(By.XPath("//*[@id=\"password_1\"]"));
            IWebElement inputPatvirtintiSlaptazodi = driver.FindElement(By.XPath("//*[@id=\"password_2\"]"));
            IWebElement buttonIssaugotiPakeitimus = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div/div/div/div/form/p[5]/button"));

            inputEsamasSlaptazodis.SendKeys(valueEsamasSlaptazodis);
            inputNaujasSlaptazodis.SendKeys(valueNaujasSlaptazodis);
            inputPatvirtintiSlaptazodi.SendKeys(valueNaujasSlaptazodis);

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            buttonIssaugotiPakeitimus.Click();

            driver.Quit();

        }

        [Test]
        public void AddProductToCart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonMedus = driver.FindElement(By.XPath("//*[@id=\"menu-item-638\"]"));
            buttonMedus.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 200)");

            IWebElement buttonIdetiIKrepseli = driver.FindElement(By.XPath("//*[@id=\"main\"]/div/div/div/div[2]/div[1]/div/div[2]/div[2]/div[3]"));
            buttonIdetiIKrepseli.Click();

            driver.Quit();
        }

        [Test]
        public void EducationFormWithValidData()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://broliumedus.lt/";

            driver.ExecuteJavaScript("window.scrollBy(0, 400)");

            IWebElement buttonEdukacijos = driver.FindElement(By.XPath("//*[@id=\"menu-item-4009\"]/a"));
            buttonEdukacijos.Click();

            driver.ExecuteJavaScript("window.scrollBy(0, 1200)");

            IWebElement buttonUzsisakytiEdukacija = driver.FindElement(By.XPath("//*[@id=\"col-1729804244\"]/div/p/a"));
            buttonUzsisakytiEdukacija.Click();

            //string valueVardas = "Tester";
            //string valueEmail = "test@tester.com";
            //string valueZinute = "Noriu";

            //IWebElement inputVardas = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/span/input"));
            //IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[2]/span/input"));
            //IWebElement inputZinute = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[3]/span/textarea"));
            //IWebElement buttonSiusti = driver.FindElement(By.XPath("//*[@id=\"wpcf7-f7-p87-o1\"]/form/div[2]/p[4]/input"));

            //inputVardas.SendKeys(valueVardas);
            //inputEmail.SendKeys(valueEmail);
            //inputZinute.SendKeys(valueZinute);

            //buttonSiusti.Click();

            driver.Quit();

        }
    }         
}
