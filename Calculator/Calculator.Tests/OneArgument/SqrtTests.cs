using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(36, 6)]
        public void LnTest(double arg, double expected)
        {
            ISingleCalculator calculator = new SquareCalculator();
            double result = calculator.Calculate(arg);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [Test]
        public void LnTest()
        {
            ISingleCalculator calculator = new SquareCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-5));
        }
    
    }
}