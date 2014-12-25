using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class AddTwoNumberTests: TestSetup
    {
        [TestMethod]
        public void AddTwoInteger()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.AddTwoIntegerNumber(2, 3);
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), Convert.ToString(5));
        }

        [TestMethod]
        public void AddTwoFloatNumber()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.AddTwoFloatNum(1 / 2, 2 / 3);
            Calculator.AdditionPage.LoadUrl();
            Calculator.AdditionPage.GetResult();
        }

        [TestMethod]
        public void AddTwoDoubleNumber()
        {
            Calculator.AdditionPage.GetBrowser("Chrome");
            Calculator.AdditionPage.AddTwoDoubleNumber(2.5, 7.5);
            Calculator.AdditionPage.LoadUrl();
            Assert.AreEqual(Calculator.AdditionPage.GetResult(), Convert.ToString(10));
        }
    }
}
