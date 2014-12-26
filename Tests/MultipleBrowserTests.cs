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
        public void Able_To_LaunchApplication_In_Firefox()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual("answer", Calculator.GetResult());
        }

        [TestMethod]
        [Ignore]
        public void Able_To_LaunchApplication_In_IE()
        {
            Calculator.GetBrowser("IE");
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual("answer", Calculator.GetResult());
        }
    }
}
