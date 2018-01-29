using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce la temperatura en grados Celsius");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La temperatura en Fahrenheit es de : {ToFahrenheit(input)}");
            Console.WriteLine($"La temperatura en Kelvin es de : {ToKelvin(input)}");
            Console.ReadKey();

        }
        public static float ToKelvin(int input)
        {
            return input + 273;
        }
        public static float ToFahrenheit(int input)
        {
            return input * 18 / 10 + 32;
        }
    }
}
