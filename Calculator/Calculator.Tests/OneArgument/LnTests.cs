using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class LnTests
    {
    [TestCase(25, 3.21887)]
    [TestCase(10, 2.30258)]

        public void LnTest(double arg, double expected)
        {
            ISingleCalculator calculator = new LnCalculator();
        double result = calculator.Calculate(arg);
        Assert.AreEqual(expected, result, 0.0001);
        }
    }
}