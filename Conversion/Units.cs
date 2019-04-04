using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Conversion
{
    /// <summary>
    /// Nothing important
    /// </summary>
    public sealed class Units
    {
        /// <summary>
        /// Prefix list
        /// </summary>
        public static List<Prefix> prefixes = new List<Prefix>();
        private static bool isInitialized = false;

        /// <summary>
        /// Initializes prefixes
        /// </summary>
        public static void InitializePrefixes()
        {
            if(isInitialized == true)
            {
                throw new Exception("The prefixes are initialized!");
            }

            try
            {
                prefixes.Add(new Prefix('Y', "Jotta", 10E24));
                prefixes.Add(new Prefix('Z', "Zetta", 10E21));
                prefixes.Add(new Prefix('E', "Exa", 10E18));
                prefixes.Add(new Prefix('P', "Peta", 10E15));
                prefixes.Add(new Prefix('T', "Tera", 10E12));
                prefixes.Add(new Prefix('G', "Giga", 10E9));
                prefixes.Add(new Prefix('M', "Mega", 10E6));
                prefixes.Add(new Prefix('k', "Kilo", 10E3));
                prefixes.Add(new Prefix('h', "Hecto", 10E2));
                //prefixes.Add(new Prefix('da', "Deca", 10));
                prefixes.Add(new Prefix('d', "Deci", 10E-1));
                prefixes.Add(new Prefix('c', "Centi", 10E-2));
                prefixes.Add(new Prefix('m', "Mili", 10E-3));
                prefixes.Add(new Prefix('u', "Micro", 10E-6));
                prefixes.Add(new Prefix('n', "Nano", 10E-9));
                prefixes.Add(new Prefix('p', "Pico", 10E-12));
                prefixes.Add(new Prefix('f', "Femto", 10E-15));
                prefixes.Add(new Prefix('a', "Atto", 10E-18));
                prefixes.Add(new Prefix('z', "Zepto", 10E-21));
                prefixes.Add(new Prefix('y', "Yocto", 10E-24));

                isInitialized = !isInitialized;
            }

            catch(Exception) when(isInitialized == true)
            {
                Console.WriteLine("The prefixes are initialized!");
            }
        }
    }

    /// <summary>
    /// All prefixes that exist, seriously 
    /// </summary>
    public struct Prefix
    {
        private char chr;
        private string prefix;
        private double value;

        /// <summary>
        /// Prefix quick constructor
        /// </summary>
        /// <param name="c">Character of prefix</param>
        /// <param name="s">Full name of prefix</param>
        /// <param name="v">Value</param>
        public Prefix(char c, string s, double v)
        {
            chr = c;
            prefix = s;
            value = v;
        }
        /// <summary>
        /// Returns char of prefix
        /// </summary>
        /// <returns></returns>
        public char GetChar()
        {
            return chr;
        }
        /// <summary>
        /// Returns prefix's name
        /// </summary>
        /// <returns></returns>
        public string GetPrefix()
        {
            return prefix;
        }
        /// <summary>
        /// Returns value's name
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return value;
        }
    }
}
