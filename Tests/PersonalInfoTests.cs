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

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
