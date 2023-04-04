using System;
using static System.Net.Mime.MediaTypeNames;

namespace Framework.EskimiDspPOM
{
    public class PersonalInfo
    {
        private static string url = "https://dsp.eskimi.com/admin?function=account&method=edit_personal_info";

        public static void Open()
        {
            LogInClass.Open();
            Driver.GoToUrl(url);
        }

        public static void ClearContactPersonFullNameInputBox()
        {
            Common.ClearInputElement("//*[@name='contact_person_full_name']");
        }

        public static void EnterFullName(string expectedFullName)
        {
            string locator = "//*[@name='contact_person_full_name']";
            Common.SendKeysToElement(locator, expectedFullName);
        }

        public static string GetFullName()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_full_name']", "value");
        }

        public static void ClearContactPersonEmailInputBox()
        {
            Common.ClearInputElement("//*[@name='contact_person_email']");
        }

        public static void EnterEmail(string expectedEmail)
        {
            string locator = "//*[@name='contact_person_email']";
            Common.SendKeysToElement(locator, expectedEmail);
        }

        public static string GetEmail()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_email']", "value");
        }

        public static void ClearContactPersonPhoneInputBox()
        {
            Common.ClearInputElement("//*[@name='contact_person_phone']");
        }

        public static void EnterPhone(string expectedPhone)
        {
            string locator = "//*[@name='contact_person_phone']";
            Common.SendKeysToElement(locator, expectedPhone);
        }

        public static string GetPhone()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_phone']", "value");
        }

        public static void EnterWeakPassword(string weakPassword)
        {
            Common.SendKeysToElement("//*[@name='plain_password']", weakPassword);
        }

        public static string GetMessageText()
        {
            return Common.GetElementText("//*[contains(text(),'weak')]");
        }

        public static void ClearPassword()
        {
            Common.ClearInputElement("//*[@name='plain_password']");
        }

        public static void EnterStrongPassword(string strongPassword)
        {
            Common.SendKeysToElement("//*[@name='plain_password']", strongPassword);
        }

        public static string GetSecondMessageText()
        {
            return Common.GetElementText("//*[contains(text(),'strong')]");
        }
    }
}
