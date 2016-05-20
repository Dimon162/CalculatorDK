using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgument
{
[TestFixture]
    public class MultiplicationCalculateTests
    {
    [TestCase(10, 5, 50)]
    [TestCase(1, 4, 4)]
    public void SimpleTest(double first, double second, double expected)
    {
        ICalculator calculator = new MultiplicationCalculate();
        double result = calculator.Calculate(first, second);
        Assert.AreEqual(expected,result);
    }
    }
}