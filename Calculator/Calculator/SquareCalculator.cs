using System;

namespace Calculator
{
    public class SquareCalculator:ISingleCalculator
        
{
    public double Calculate(double firstArgument)
    {
        return Math.Sqrt(firstArgument);
    }
}
}