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
        public void UpdateContactPersonFullName()
        {
            string expectedFullName = "Jurga Jurgaitytė";

            PersonalInfo.ClearContactPersonFullNameInputBox();
            PersonalInfo.EnterFullName(expectedFullName);
            string actualFullName = PersonalInfo.GetFullName();

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test]
        public void UpdateContactPersonEmail()
        {
            string expectedEmail = "jurga@myemail.com";

            PersonalInfo.ClearContactPersonEmailInputBox();
            PersonalInfo.EnterEmail(expectedEmail);
            string actualEmail = PersonalInfo.GetEmail();

            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test]
        public void UpdateContactPersonPhone()
        {
            string expectedPhone = "+37065656565";

            PersonalInfo.ClearContactPersonPhoneInputBox();
            PersonalInfo.EnterPhone(expectedPhone);
            string actualPhone = PersonalInfo.GetPhone();

            Assert.AreEqual(expectedPhone, actualPhone);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
