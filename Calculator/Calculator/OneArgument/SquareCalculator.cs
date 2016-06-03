using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// Класс, реализующий операцию извлечения квадратного корня
    /// </summary>
    public class SquareCalculator : ISingleCalculator

    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Невозможно извлечь корень отрицательного числа");
            }

            return Math.Sqrt(firstArgument);
        }
    }
}