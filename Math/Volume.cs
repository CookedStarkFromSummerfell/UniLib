using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Math
{
    /// <summary>
    /// Volume of spatial figures
    /// </summary>
    public class Volume
    {
        /// <summary>
        /// Stair's volume
        /// </summary>
        /// <param name="c">Stairs's count</param>
        /// <param name="a">Side of one stair</param>
        /// <param name="h">Height of first stair</param>
        /// <param name="l">Length of stairs</param>
        /// <returns>Stair's volume</returns>
        public static double StairsVolume(int c, double a, double h, double l)
        {
            if (c == 0 || a == 0 || h == 0 || l == 0) return 0;

            return Area.Stairs(c, a, h) * l;
        }
        /// <summary>
        /// Stair's volume
        /// </summary>
        /// <param name="c">Stairs's count</param>
        /// <param name="s">Rectangle's area</param>
        /// <param name="l">Length of stairs</param>
        /// <returns>Stair's volume</returns>
        public static double StairsVolume(int c, double s, double l)
        {
            if (c == 0 || s == 0 || l == 0) return 0;

            return Area.Stairs(c, s) * l;
        }
        /// <summary>
        /// Stair's volume
        /// </summary>
        /// <param name="s">Stair's area</param>
        /// <param name="w">Stair's width</param>
        /// <returns>Stair's volume</returns>
        public static double StairsVolume(int s, double w)
        {
            if (s == 0 || w == 0) return 0;

            return s * w;
        }
    }
}
