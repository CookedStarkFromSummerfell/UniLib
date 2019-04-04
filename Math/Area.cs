using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Math
{
    /// <summary>
    /// Class with super hard algorithms to calculate area of figure
    /// </summary>
    public class Area
    {
        /// <summary>
        /// Stair's area
        /// </summary>
        /// <param name="c">Stair's count</param>
        /// <param name="a">First side</param>
        /// <param name="h">Height of first stair</param>
        /// <returns>Stair's area</returns>
        public static double Stairs(int c, double a, double h)
        {
            if (c == 0 || a == 0 || h == 0) return 0;

            return MoreMaths.Factorial(c) * (a * h);
        }
        /// <summary>
        /// Stair's area
        /// </summary>
        /// <param name="c">Stair's count</param>
        /// <param name="f">Rectangle's qrea</param>
        /// <returns></returns>
        public static double Stairs(int c, double f)
        {
            if (c == 0 || f == 0) return 0;

            return MoreMaths.Factorial(c) * f;
        }
    }
}
