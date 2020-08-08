using ConsoleAppNetCore.TestClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CalculatorTest
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
