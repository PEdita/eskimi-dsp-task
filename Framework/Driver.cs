using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Framework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver(options);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }
    }
}
