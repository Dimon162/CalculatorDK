using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class AdditionCalculateTests
    {
        [Test]
        public void SimpleTest()
        {
            ICalculator calculator = new AdditionCalculate();
            double result = calculator.Calculate(2, 3);
         Assert.AreEqual(5,result);   
        }
    }
}