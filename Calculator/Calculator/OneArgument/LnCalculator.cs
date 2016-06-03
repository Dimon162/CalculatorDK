using System;

namespace Calculator.OneArgument
{
  /// <summary>
  /// Класс, реализующий операцию логарифма
  /// </summary>
    public class LnCalculator : ISingleCalculator
    {
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Невозможно вычислить логарифм отрицательного числа");
            }

            return Math.Log(firstArgument);
        } 
    }
}