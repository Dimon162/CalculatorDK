using System;

namespace Calculator
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
                   return new DivisionCalculate();
                    
                case "button3":
                    return new MultiplicationCalculate();
                   
                case "button4":
                    return new SubtractionCalculate();
                    
                default:
                    throw new Exception("Unknown peration");
            
            }
        }
    }
}