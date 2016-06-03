using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// Фабрика калькуляторов
    /// </summary>
    public static class SingleFactory
    
    {
        public static ISingleCalculator Create(string name)
        {
            switch (name)
            {
                case "button5":
                    return new LnCalculator();
                case "button6":
                    return new SquareCalculator();
               default:
                    throw new Exception("Unknown peration");

            }
        }
    }
}