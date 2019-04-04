using System;
using System.Collections.Generic;
using System.Linq;

namespace Science.Hard
{
    /// <summary>
    /// Extended Random class
    /// </summary>
    public class Rand
    {
        /// <summary>
        /// Random
        /// </summary>
        protected static Random rand;

        /// <summary>
        /// Must initialize to prepare the entire class to work properly,
        /// If not, the compiler will output an error!
        /// </summary>
        public Rand()
        {
            rand = new Random();
        }
        /// <summary>
        /// Other constructor whuch use earlier defined Random class
        /// </summary>
        /// <param name="random">Random value, that you could define earlier</param>
        public Rand(Random random)
        {
            rand = random;
        }

        /// <summary>
        /// Choices the object of array
        /// </summary>
        /// <typeparam name="T">Type of object in array type</typeparam>
        /// <param name="arr">Array</param>
        /// <returns>Random choice from array</returns>
        public static T Choice<T>(T[] arr)
        {
            return arr[rand.Next(0, arr.Length)];
        }
        /// <summary>
        /// Choices the object from list
        /// </summary>
        /// <typeparam name="T">Type of object in list</typeparam>
        /// <param name="list">List</param>
        /// <returns>Random choice from list</returns>
        public static T Choice<T>(List<T> list)
        {
            return list[rand.Next(0, list.Count)];
        }
        /// <summary>
        /// Choices the object from dictionary
        /// </summary>
        /// <typeparam name="T">First dictionary item</typeparam>
        /// <typeparam name="U">Second dictionary item</typeparam>
        /// <param name="dict">Dictionary we use</param>
        public static U Choice<T, U>(Dictionary<T, U> dict)
        {
            return dict.ElementAt(rand.Next(0, dict.Count)).Value;
        }
    }
}
