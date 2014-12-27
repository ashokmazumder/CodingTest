using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class MultipleBrowserTests: TestSetup
    {
        [TestMethod]
        public void Able_To_LaunchApplication_In_Chrome()
        {
            Calculator.GetBrowser("Chrome");
            Calculator.LoadUrlToWebBrowser();
            Assert.IsTrue(Calculator.IsAtPage());
        }

        [TestMethod]
        [TestCategory("SanityTests")]
        public void Able_To_LaunchApplication_In_Firefox()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual("answer", Calculator.GetResult());
        }

        [TestMethod]
        public void Able_To_LaunchApplication_In_IE()
        {
            Calculator.GetBrowser("IE");
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual("answer", Calculator.GetResult());
        }

        [TestMethod]
        [TestCategory("SanityTests")]
        public void LaunchCalculatorInFirefoxWithHttp()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.URL = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.pageTitle = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual("answer", Calculator.GetResult());
        }

        [TestMethod]
        public void LaunchCalculatorInChromeWithHttp()
        {
            Calculator.GetBrowser("Chrome");
            Calculator.URL = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.pageTitle = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.LoadUrlToWebBrowser();
            Assert.IsTrue(Calculator.IsAtPage());
        }

        [TestMethod]
        public void LaunchCalculatorInIEWithHttp()
        {
            Calculator.GetBrowser("IE");
            Calculator.URL = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.pageTitle = "http://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.LoadUrlToWebBrowser();
            Assert.IsTrue(Calculator.IsAtPage());
        }
    }
}
