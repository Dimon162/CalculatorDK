using System;
using Calculator.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    public class SingleFactoryTest
    {
        [TestCase("button5", typeof(LnCalculator))]
        [TestCase("button6", typeof(SquareCalculator))]
        public void SimpleTest(string name, Type type)
        {
            ISingleCalculator calculator = SingleFactory.Create(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}