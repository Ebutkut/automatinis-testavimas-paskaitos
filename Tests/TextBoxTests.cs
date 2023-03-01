using Framework;
using Framework.Pages;
using NUnit.Framework;

namespace Tests
{
    internal class TextBoxTests
    {
        [Test]
        public void FormWithValidData()
        {

            Driver.OpenUrl("https://demoqa.com/text-box");
            

            string valueFullName = "Tester";
            string valueEmail = "test@tester.com";
            string valueCurrentAddress = "Test Address";
            string valuePermanentAddress = "Test Address 2";

            TextBox.EnterFullName(valueFullName);
            TextBox.EnterEmail(valueEmail);
            TextBox.EnterCurrentAddress(valueCurrentAddress);
            TextBox.EnterPermanentAddress(valuePermanentAddress);
            TextBox.ClickSubmit();

            //driver.ExecuteJavaScript("window.scrollBy(0, 200)")????????????;
            
            string actualResult1 = TextBox.GetFullName();
            string actualResult2 = TextBox.GetEmail();
            string actualResult3 = TextBox.CurrentAddress();
            string actualResult4 = TextBox.PermanentAddress();

            Assert.AreEqual($"Name:{valueFullName}", TextBox.GetFullName());
            Assert.AreEqual($"Email:{valueEmail}", TextBox.GetEmail());
            Assert.AreEqual($"Current Address :{valueCurrentAddress}", TextBox.CurrentAddress());
            Assert.AreEqual($"Permananet Address :{valuePermanentAddress}", TextBox.PermanentAddress());

            Driver.QuitDriver();

        }
     }
}
