using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Tests
{
    [TestClass]
    public class TestSetup
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Calculator.URL = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            Calculator.pageTitle = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";
        }

        [TestCleanup]
        public void CleanUp()
        {
            Calculator.CloseBrowser();
        }
    }
}
