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

        public static void EnterFullName(string text)
        {
            string locator = "//*[@name='contact_person_full_name']";
            Common.SendKeysToElement(locator, text);
        }

        public static string GetFullName()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_full_name']", "value");
        }

        public static void ClearContactPersonEmailInputBox()
        {
            Common.ClearInputElement("//*[@name='contact_person_email']");
        }

        public static void EnterEmail(string text)
        {
            string locator = "//*[@name='contact_person_email']";
            Common.SendKeysToElement(locator, text);
        }

        public static string GetEmail()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_email']", "value");
        }

        public static void ClearContactPersonPhoneInputBox()
        {
            Common.ClearInputElement("//*[@name='contact_person_phone']");
        }

        public static void EnterPhone(string text)
        {
            string locator = "//*[@name='contact_person_phone']";
            Common.SendKeysToElement(locator, text);
        }

        public static string GetPhone()
        {
            return Common.GetAttributeValue("//*[@name='contact_person_phone']", "value");
        }
    }
}
