using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double degrees)
        {
            return (degrees * 9 / 5) + 32;
        }
    }
}
