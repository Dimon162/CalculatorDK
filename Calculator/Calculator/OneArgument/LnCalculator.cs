using System;

namespace Calculator.OneArgument
{
    /// <summary>
    /// 
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
            return Math.Log(firstArgument);
        } 
    }
}