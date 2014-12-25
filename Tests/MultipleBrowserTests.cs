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
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.LoadUrl();
            Assert.IsTrue(Calculator.AdditionPage.IsAt());
        }

        [TestMethod]
        public void Able_To_LaunchApplication_In_Firefox()
        {
            Calculator.AdditionPage.GetBrowser("Firefox");
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), "answer");
        }

        [TestMethod]
        [Ignore]
        public void Able_To_LaunchApplication_In_IE()
        {
            Calculator.AdditionPage.GetBrowser("IE");
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), "answer");
        }
    }
}
