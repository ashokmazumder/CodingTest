using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class ErrorScenarioTests:TestSetup
    {
        [TestMethod]
        [TestCategory("NegativeTests")]
        public void AddTwoString()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoString("abc", "xyz");
            Assert.AreEqual("Error: Incorrect datatype", Calculator.GetResult()); ;
        }

        [TestMethod]
        [TestCategory("NegativeTests")]
        public void PerformAddWithOneElement()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.PerformAddWithOneElement(2);
            Assert.AreEqual("Error: Enter second number", Calculator.GetResult());
        }
        [TestMethod]
        [TestCategory("NegativeTests")]
        public void AddTwoNumberWhenOperatorMissing()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoNumberWhenOperatorMissing(2, 5);
            Assert.AreEqual("Error: Operator Missing", Calculator.GetResult());
        }
    }
}
