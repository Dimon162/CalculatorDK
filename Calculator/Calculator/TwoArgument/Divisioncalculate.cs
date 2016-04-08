namespace Calculator.TwoArgument
{
    public class DivisionCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArument)
        {
            return firstArgument/secondArument;
        }
    }
}