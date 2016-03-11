namespace Calculator
{
    public class SubtractionCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArument)
        {
            return firstArgument - secondArument;
        } 
    }
}