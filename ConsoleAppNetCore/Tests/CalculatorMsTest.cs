
namespace ConsoleAppNetCore.TestClasses
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CalculatorMsTest
    {
        [TestMethod]
        public void Calculator_Add_Correct()
        {
            Calculator calculator = new Calculator(0);
            calculator.Add(10);
            calculator.Add(20);
            calculator.Add(-20);
            calculator.Add(40);
            Assert.AreEqual(50, calculator.Result);
        }

        [TestMethod]
        public void Calculator_Multiply_Correct()
        {
            Calculator calculator = new Calculator(13);
            calculator.Multiply(13);
            Assert.AreEqual(169, calculator.Result);
        }

        [TestMethod]
        public void Calculator_Divide_Correct()
        {
            Calculator calculator = new Calculator(169);
            calculator.Divide(13);
            Assert.AreEqual(13, calculator.Result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_Divide_DivdeByZeroException()
        {
            Calculator calculator = new Calculator(169);
            calculator.Divide(0);
        }
    }
}
