using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(32));
            Console.WriteLine(TempConverter.FahrenheitToCelsius(75));
        }
    }
}
