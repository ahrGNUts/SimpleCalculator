using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultFromNonSymbolOperation()
        {
            int num1 = 1;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("add", num1, num2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultFromSymbolOperation()
        {
            int num1 = 4;
            int num2 = 2;
            double result = _calculatorEngine.Calculate("+", num1, num2);
            Assert.AreEqual(6, result);
        }
    }
}
