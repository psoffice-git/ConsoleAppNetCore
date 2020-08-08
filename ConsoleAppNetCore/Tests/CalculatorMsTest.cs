using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore.TestClasses
{
    [TestClass]
    public class CalculatorMsTest
    {
        [TestMethod]
        public void Calculator_Multiply_Correct()
        {
            Calculator calculator = new Calculator();
            calculator.Add(10);
            calculator.Multiply(6);
            Assert.AreEqual(60, calculator.Result);
        }
    }
}
