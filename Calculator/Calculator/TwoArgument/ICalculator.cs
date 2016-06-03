namespace Calculator.TwoArgument
{
    /// <summary>
    /// Интерфейс для операций калькулятора, принимающих два аргумента
    /// </summary>
    public interface ICalculator
    {
        double Calculate(double firstArgument, double secondArument);
    }
}