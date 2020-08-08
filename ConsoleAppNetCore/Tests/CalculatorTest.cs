using ConsoleAppNetCore.TestClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNetCore.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void Calculator_Multiply_Correct()
        {
            Calculator calculator = new Calculator();
            calculator.Add(10);
            calculator.Multiply(6);
            Assert.AreEqual(60f, calculator.Result); 
        }
    }
}
