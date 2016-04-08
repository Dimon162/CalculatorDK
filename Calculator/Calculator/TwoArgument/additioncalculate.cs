namespace Calculator.TwoArgument
{
    public class AdditionCalculate: ICalculator

{
    public double Calculate(double firstArgument, double secondArument)
    {
        return firstArgument + secondArument;
    }
}
}