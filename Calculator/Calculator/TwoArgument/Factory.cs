using System;

namespace Calculator.TwoArgument
{
    public static class Factory
    {
        public static ICalculator Create(string name)
        {
            switch (name)
            {
                case "button1":
                    return new AdditionCalculate();

                case "button2":
                   return new SubtractionCalculate();
                    
                case "button3":
                    return new MultiplicationCalculate();
                   
                case "button4":
                    return new DivisionCalculate();
                    
                default:
                    throw new Exception("Unknown operation");
            
            }
        }
    }
}