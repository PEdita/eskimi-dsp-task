using Framework;
using Framework.EskimiDspPOM;
using NUnit.Framework;

namespace Tests
{
    public class PersonalInfoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            PersonalInfo.Open();
        }

        [Test] 
        public void UpdateContactMainInfo()
        {
            string expectedFullName = "Jurga Jurgaitytė";
            string expectedEmail = "jurga@myemail.com";
            string expectedPhone = "+37065656565";

            PersonalInfo.ClearContactPersonFullNameInputBox();
            PersonalInfo.EnterFullName(expectedFullName);
            string actualFullName = PersonalInfo.GetFullName();

            PersonalInfo.ClearContactPersonEmailInputBox();
            PersonalInfo.EnterEmail(expectedEmail);
            string actualEmail = PersonalInfo.GetEmail();

            PersonalInfo.ClearContactPersonPhoneInputBox();
            PersonalInfo.EnterPhone(expectedPhone);
            string actualPhone = PersonalInfo.GetPhone();

            Assert.AreEqual(expectedFullName, actualFullName);
            Assert.AreEqual(expectedEmail, actualEmail);
            Assert.AreEqual(expectedPhone, actualPhone);
        }

        [Test]
        public void FillInBillingInfo()
        {
            string expectedCompanyTitle = "UAB Pasaulis";
            string expectedCompanyAddress = "Gedimino pr. 99";

            PersonalInfo.ClearCompanyTitleInputBox();
            PersonalInfo.EnterCompanyTitle(expectedCompanyTitle);
            string actualCompanyTitle = PersonalInfo.GetCompanyTitle();

            PersonalInfo.ClearCompanyAddressInputBox();
            PersonalInfo.EnterCompanyAddress(expectedCompanyAddress);
            string actualCompanyAddress = PersonalInfo.GetCompanyAddress();

            Assert.AreEqual(expectedCompanyTitle, actualCompanyTitle);
            Assert.AreEqual(expectedCompanyAddress, actualCompanyAddress);
        }

        [Test] 
        public void ChangePasswordToWeakAndThenToStrong()
        {
            string weakPassword = "abcde";
            string expectedMessage = "weak";

            PersonalInfo.EnterWeakPassword(weakPassword);
            string actualMessage = PersonalInfo.GetMessageText();

            Assert.AreEqual(expectedMessage, actualMessage);

            string strongPassword = "pakalne123456";
            string expectedText = "strong";

            PersonalInfo.ClearPassword();
            PersonalInfo.EnterStrongPassword(strongPassword);
            string actualText = PersonalInfo.GetSecondMessageText();

            Assert.AreEqual(expectedText, actualText);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
