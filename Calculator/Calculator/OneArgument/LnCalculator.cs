using System;

namespace Calculator.OneArgument
{
    public class LnCalculator : ISingleCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        } 
    }
}