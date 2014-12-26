using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class AddTwoNumberTests: TestSetup
    {
        [TestMethod]
        public void AddTwoPositiveIntegerResultsPositiveNum()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(2, 3);
            Assert.AreEqual(Calculator.GetResult(), Convert.ToString(5));
        }

        [TestMethod]
        public void AddPositiveAndNegativeIntNumberResultsPositiveNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-2, 3);
            Assert.AreEqual(Convert.ToString(1), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        public void AddPositiveAndNegativeIntNumberResultsNegativeNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-3, 2);
            Calculator.LoadUrlToWebBrowser();
            Assert.AreEqual(Convert.ToString(-1), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        public void AddTwoNegativeIntNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoIntegerNumber(-3, -2);
            Assert.AreEqual(Convert.ToString(-5), Calculator.GetResult());
        }

        
        [TestMethod]
        public void AddTwoDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(2.5, 7.5);
            Assert.AreEqual(Convert.ToString(10), Calculator.GetResult());
        }

        [TestMethod]
        public void AddPositiveAndNegativeDoubleNumberResultsPositiveDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(10.25, -3.15);
            Assert.AreEqual(Convert.ToString(7.10), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        public void AddPositiveAndNegativeDoubleNumberResultsNegativeDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(-10.25, 0.24);
            Assert.AreEqual(Convert.ToString(-10.01), Calculator.GetResult());
        }

        //This test will fail as there is a bug in the software
        [TestMethod]
        public void AddTwoNegativeDoubleNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoDoubleNumber(-3.33, -2.22);
            Assert.AreEqual(Convert.ToString(-5.55), Calculator.GetResult());
        }

        //Add real numbers
        [TestMethod]
        public void AddTwoFloatNumber()
        {
            Calculator.GetBrowser("Firefox");
            Calculator.AdditionOperation.AddTwoFloatNum(1/3, 2/3);
            Assert.AreEqual(Convert.ToString(1), Calculator.GetResult());
        }
    }
}
