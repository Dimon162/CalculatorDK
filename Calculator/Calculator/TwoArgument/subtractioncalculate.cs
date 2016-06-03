namespace Calculator.TwoArgument
{
    /// <summary>
    /// Класс, реализующий операцию вычитания
    /// </summary>
    public class SubtractionCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArument)
        {
            return firstArgument - secondArument;
        } 
    }
}