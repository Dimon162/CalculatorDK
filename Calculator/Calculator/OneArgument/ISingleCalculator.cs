namespace Calculator.OneArgument
{
    /// <summary>
    /// Интерфейс для операций калькулятора, принимающих один аргумент
    /// </summary>
    public interface ISingleCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns></returns>
        double Calculate(double firstArgument);
    }
}