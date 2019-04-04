namespace Science.Math
{
    /// <summary>
    /// It has more mathematic algorithms I think
    /// </summary>
    public class MoreMaths
    {
        /// <summary>
        /// Factorial of number we want so...
        /// </summary>
        /// <param name="number">Number, just that</param>
        /// <returns>Factorial of number</returns>
        public static int Factorial(int number)
        {
            if (number == 0 || number == 1) return 1;

            int n = 1;
            int num = 1;

            while(num <= number)
            {
                n *= num;

                num++;
            }

            return n;
        }

        /// <summary>
        /// Square power
        /// </summary>
        /// <param name="num">Number to square</param>
        /// <returns>Square of number</returns>
        public static double Sqp(double num)
        {
            return num * num;
        }
        /// <summary>
        /// Cube power
        /// </summary>
        /// <param name="num">Number to cube</param>
        /// <returns>Cube of number</returns>
        public static double Cbp(double num)
        {
            return Sqp(num) * num;
        }
    }
}
