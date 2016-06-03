namespace Calculator.TwoArgument
{
    /// <summary>
    /// Класс, реализующий операцию умножения
    /// </summary>
    public class MultiplicationCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArument)
        {
            return firstArgument * secondArument;
        } 
    }
}