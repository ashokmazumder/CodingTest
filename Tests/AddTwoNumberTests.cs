using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
namespace Tests
{
    [TestClass]
    public class AddTwoNumberTests: TestSetup
    {
        [TestMethod]
        [TestCategory("SanityTests"), TestCategory("FunctionalTests")]
        public void AddTwoPositiveIntegerResultsPositiveNum()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(2, 3);
            Assert.AreEqual(Convert.ToString(5), Calculator.GetResult());
        }

        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddTwoPositiveIntegerResultsOutofRangeValue()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(2147483647, 3);
            Assert.AreEqual("2.14748E+9", Calculator.GetResult());
        }

        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddPositiveAndNegativeIntNumberResultsPositiveNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-2, 3);
            Assert.AreEqual(Convert.ToString(1), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddPositiveAndNegativeIntNumberResultsNegativeNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-3, 2);
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual(Convert.ToString(-1), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddTwoNegativeIntNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-3, -2);
            Assert.AreEqual(Convert.ToString(-5), Calculator.GetResult());
        }

        
        [TestMethod]
        [TestCategory("SanityTests"), TestCategory("FunctionalTests")]
        public void AddTwoDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(2.5, 7.5);
            Assert.AreEqual(Convert.ToString(10), Calculator.GetResult());
        }

        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddPositiveAndNegativeDoubleNumberResultsPositiveDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(10.25, -3.15);
            Assert.AreEqual(Convert.ToString(7.10), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddPositiveAndNegativeDoubleNumberResultsNegativeDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(-10.25, 0.24);
            Assert.AreEqual(Convert.ToString(-10.01), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        [TestCategory("FunctionalTests")]
        public void AddTwoNegativeDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(-3.33, -2.22);
            Assert.AreEqual(Convert.ToString(-5.55), Calculator.GetResult());
        }
    }
}
