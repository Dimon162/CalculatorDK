using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentTest
{
[TestFixture]
    public class MultiplicationCalculateTests
    {
    [Test]
    public void SimpleTest()
    {
        ICalculator calculator = new MultiplicationCalculate();
        double result = calculator.Calculate(2, 10);
        Assert.AreEqual(20,result);
    }
    }
}