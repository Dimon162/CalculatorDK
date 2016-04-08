namespace Calculator.TwoArgument
{
    public class MultiplicationCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArument)
        {
            return firstArgument * secondArument;
        } 
    }
}