using System;

namespace Calculator
{
    public class LnCalculator : ISingleCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        } 
    }
}