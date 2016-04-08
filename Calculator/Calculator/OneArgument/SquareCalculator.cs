using System;

namespace Calculator.OneArgument
{
    public class SquareCalculator : ISingleCalculator

    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}