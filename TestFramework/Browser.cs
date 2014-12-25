using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
namespace TestFramework
{
    public static class Browser
    {
        public static IWebDriver webDriver;

        public static void GetWebBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
            }
        }

        public static void LoadUrl(string url)
        {
            webDriver.Url = url;
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Close()
        {
            webDriver.Close();
            webDriver.Dispose();
        }

        internal static string FindResult()
        {
            IWebElement resultWebElement;
            resultWebElement = webDriver.FindElement(By.TagName("body"));
            return resultWebElement.Text;

        }
    }
}
