using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Science.Math
{
    /// <summary>
    /// Physic stuff and more
    /// </summary>
    public class Physic
    {
        /// <summary>
        /// Newton's law of universal gravitation
        /// </summary>
        /// <param name="m">Mass of first object in Kilogram</param>
        /// <param name="n">Mass of second object in Kilogram</param>
        /// <param name="r">Range between two objects in Metres</param>
        /// <returns>Force between two objects in Niutons</returns>
        public static double UnivGrav(double m, double n, double r)
        {
            return Constants.G * (m * n / MoreMaths.Sqp(r));
        }

        /// <summary>
        /// Coulomb's law
        /// </summary>
        /// <param name="c">First elementary charge in Coulombs</param>
        /// <param name="v">Second elementary charge in Coulombs</param>
        /// <param name="r">Range between two charges in Metres</param>
        /// <returns>Force between two charges in Niutons</returns>
        public static double CoulLaw(double c, double v, double r)
        {
            return Constants.k * (c * v / MoreMaths.Sqp(r));
        }

        /// <summary>
        /// Kelvin to Celcius temperature conversion
        /// </summary>
        /// <param name="K">Value of temperature in Kelvin</param>
        /// <returns>Temperature in Celcius degrees</returns>
        public static double KelvinToCelcius(double K)
        {
            return K - Constants.azC;
        }
        /// <summary>
        /// Kelvin to Fahrenheit temperature conversion
        /// </summary>
        /// <param name="K">Value of temperature in Kelvin</param>
        /// <returns>Temperature in Fahrenheit degrees</returns>
        public static double KelvinToFahrenheit(double K)
        {
            return K * 1.8 - Constants.azF;
        }

        /// <summary>
        /// Celcius to Kelvin temperature conversion
        /// </summary>
        /// <param name="C">Value in Celcius degrees</param>
        /// <returns>Temperature in Kelvins</returns>
        public static double CelciusToKelvin(double C)
        {
            return C + Constants.azC;
        }
        /// <summary>
        /// Celcius to Fahrenheit temperature conversion
        /// </summary>
        /// <param name="C">Value in Celcius degrees</param>
        /// <returns>Temperature in Fahrenheit degrees</returns>
        public static double CelciusToFahrenheit(double C)
        {
            return C * 1.8 + 32;
        }


        /// <summary>
        /// Fahrenheit to Kelvin temperature conversion
        /// </summary>
        /// <param name="F">Value in Fahrenheit degrees</param>
        /// <returns>Temperature in Kelvins</returns>
        public static double FahrenheitToKelvin(double F)
        {
            return (F + Constants.azF) / 1.8;
        }
        /// <summary>
        /// Fahrenheit to Celcius temperature conversion
        /// </summary>
        /// <param name="F">Value in Fahrenheit degrees</param>
        /// <returns>Temperature in Celcius degrees</returns>
        public static double FahrenheitToCelcius(double F)
        {
            return (F - 32) / 1.8;
        }
    }
}
