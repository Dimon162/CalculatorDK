using Calculator.TwoArgument;
using NUnit.Framework;
namespace Calculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class DivisionCalculateTests
    {
        [TestCase(10, 5, 2)]
        [TestCase(12, 4, 4)]
        public void SimpleTest(double first, double second, double expected)
        {
            ICalculator calculator = new DivisionCalculate();
            double result = calculator.Calculate(first,second);
            Assert.AreEqual(expected,result);
        }

    }
}