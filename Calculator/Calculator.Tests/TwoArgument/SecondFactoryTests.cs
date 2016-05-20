using System;
using Calculator.OneArgument;
using Calculator.TwoArgument;
using NUnit.Framework;

namespace Calculator.Tests.TwoArgument
{
    public class SecondFactoryTests
    {
        [TestCase("button1", typeof(AdditionCalculate))]
        [TestCase("button2", typeof(DivisionCalculate))]
        [TestCase("button3", typeof(MultiplicationCalculate))]
        [TestCase("button4", typeof(SubtractionCalculate))]
        public void SimpleTest(string name, Type type)
        {
            ICalculator calculator = Factory.Create(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}