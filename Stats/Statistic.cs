using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Stats
{
    /// <summary>
    /// Statistic methods
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// Arithmetic average of number's collections
        /// </summary>
        /// <param name="nums">All numbers of collection</param>
        /// <returns>Arithmetic average</returns>
        public static double ArtiAver(params double[] nums)
        {
            double result = 0;

            foreach(double d in nums) result += d;

            return result / nums.Length;
        }

        /// <summary>
        /// Arithmetic average of list
        /// </summary>
        /// <param name="list">List of numbers</param>
        /// <returns>Arithmetic average</returns>
        public static double ArtiAver(List<double> list)
        {
            double result = 0;

            foreach (double d in list) result += d;

            return result / list.Count;
        }

        /// <summary>
        /// Median of number's collection or just array
        /// </summary>
        /// <param name="nums">Array of numbers or just array</param>
        /// <returns>A number in the middle of collection</returns>
        public static double Median(params double[] nums)
        {
            Array.Sort(nums, (x, y) => y.CompareTo(x));

            if(nums.Length % 2 == 0)
            {
                int i = nums.Length / 2;

                return (nums[i] + nums[-i]) / 2;
            }

            double d = nums.Length / 2;

            int rd = (int)System.Math.Round(d);

            return nums[nums.Length - rd];
        }

        /// <summary>
        /// Median of list
        /// </summary>
        /// <param name="list">List of numbers</param>
        /// <returns>A number in the middle of list</returns>
        public static double Median(List<double> list)
        {
            list.Sort();
            
            if(list.Count % 2 == 0)
            {
                int i = list.Count / 2;

                return (list[i] - list[-i]) / 2;
            }

            double d = list.Count / 2;

            int rd = (int)System.Math.Round(d);

            return list[list.Count - rd];
        }

        /// <summary>
        /// Interval of number's collections
        /// </summary>
        /// <param name="nums">Array of numbers</param>
        /// <returns>Number's amplitude</returns>
        public static double Interval(params double[] nums) => nums.Max() - nums.Min();

        /// <summary>
        /// Interval of list
        /// </summary>
        /// <param name="list">List of numbers</param>
        /// <returns>Number's amplitude</returns>
        public static double Interval(List<double> list) => list.Max() - list.Min();
    }
}
