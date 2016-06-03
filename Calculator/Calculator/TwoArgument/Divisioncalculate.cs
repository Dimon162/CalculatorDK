using System;

namespace Calculator.TwoArgument
{
    /// <summary>
    /// Класс, реализующий операцию деления
    /// </summary>
    public class DivisionCalculate: ICalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            return firstArgument/secondArgument;
        }
    }
}