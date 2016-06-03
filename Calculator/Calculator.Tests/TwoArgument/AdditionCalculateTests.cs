using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgument
{
    [TestFixture]
    public class AdditionCalculateTests
    {
        [TestCase(11520.30, 10, 11530.30)]
        [TestCase(12, 4, 16)]
        public void SimpleTest(double first, double second, double expected)
        {
            ICalculator calculator = new AdditionCalculate();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}