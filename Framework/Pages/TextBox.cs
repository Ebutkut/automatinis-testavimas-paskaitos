using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.LayerTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class TextBox
    {
        public static void ClickSubmit()
        {
         
            string locator = "//*[@id='submit']";
            Common.ClickElement(locator);
        }

        public static string CurrentAddress()
        {
          string locator = "//*[@id='output']//*[@id='currentAddress']";
          return Common.GetElementText(locator);
        }

        public static void EnterCurrentAddress(string valueCurrentAddress)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, valueCurrentAddress);
        }

        public static void EnterEmail(string valueEmail)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, valueEmail);
        }

        public static void EnterFullName(string valueFullName)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, valueFullName);
        }

        public static void EnterPermanentAddress(string valuePermanentAddress)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, valuePermanentAddress);
        }

        public static string GetEmail()
        {          
            string locator = "//*[@id='output']//*[@id='email']";
            return Common.GetElementText(locator);
        }

        public static string GetFullName()
        {
            string locator = "//*[@id='output']//*[@id='name']";
            return Common.GetElementText(locator);
        }

        public static string PermanentAddress()
        {
            string locator = "//*[@id='output']//*[@id='permanentAddress']";
            return Common.GetElementText(locator);
        }
    }
}
