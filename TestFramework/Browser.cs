using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
namespace TestFramework
{
    internal static class Browser
    {
        private static IWebDriver webDriver;

        internal static void GetWebBrowser(string browser)
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

        internal static void LoadUrlToWebBrowser(string url)
        {
            webDriver.Url = url;
        }

        internal static string Title
        {
            get { return webDriver.Title; }
        }

        internal static void CloseBrowser()
        {
            webDriver.Close();
            webDriver.Dispose();
        }

        internal static string GetResult()
        {
            IWebElement resultWebElement;
            resultWebElement = webDriver.FindElement(By.TagName("body"));
            return resultWebElement.Text;

        }
    }
}
