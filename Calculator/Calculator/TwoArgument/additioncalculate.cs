namespace Calculator.TwoArgument
{
    /// <summary>
    /// Класс, реализующий операцию сложения
    /// </summary>
    public class AdditionCalculate: ICalculator

{
    public double Calculate(double firstArgument, double secondArument)
    {
        return firstArgument + secondArument;
    }
}
}