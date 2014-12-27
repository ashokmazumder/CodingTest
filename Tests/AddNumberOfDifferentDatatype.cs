using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class AddNumberOfDifferentDatatype: TestSetup
    {
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddIntWithDoubleResultsPositiveNum()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddInterAndDouble(2, 3.54);
            Assert.AreEqual(Convert.ToString(5.54), Calculator.GetResult());
        }

        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddIntWithDoubleResultsNegativeNum()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddInterAndDouble(2, -3.54);
            Assert.AreEqual(Convert.ToString(-1.54), Calculator.GetResult());
        }

        //This test fails as there is a bug in software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddIntWithString()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddIntegerAndString(2, "abcd");
            Assert.AreEqual("Error: Can not add Integer with String", Calculator.GetResult());
        }

        //This test fails as there is a bug in software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddDoubleWithString()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddDoubleAndString(2.33, "abcd");
            Assert.AreEqual("Error: Can not add Double with String", Calculator.GetResult());
        }
    }
}
