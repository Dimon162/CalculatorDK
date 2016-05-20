using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgument
{
    [TestFixture]
    public class DivisionCalculateTests
    {
        [TestCase(10520.40, 2, 5260.20)]
        [TestCase(8, 4, 2)]
        public void SimpleTest(double first, double second, double expected)
        {
            ICalculator calculator = new DivisionCalculate();
            double result = calculator.Calculate(first,second);
            Assert.AreEqual(expected,result);
        }

    }
}