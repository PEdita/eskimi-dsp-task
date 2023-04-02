using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Framework
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        internal static void WaitForUrlToOpen(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlContains(locator));
        }
    }
}
