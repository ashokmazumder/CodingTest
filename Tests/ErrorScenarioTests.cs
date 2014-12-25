using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class ErrorScenarioTests:TestSetup
    {
        [TestMethod]
        public void AddTwoString()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.AddTwoString("abc", "xyz");
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(),"answer");
        }

        [TestMethod]
        public void PerformAddWithOneElement()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.PerformAddWithOneElement(2);
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), Convert.ToString(2));
        }
        [TestMethod]
        public void AddTwoNumberWhenOperatorMissing()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.AddTwoNumberWhenOperatorMissing(2, 5);
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), Convert.ToString(25));
        }
    }
}
