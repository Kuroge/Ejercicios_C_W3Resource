using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Highest number: {Math.Max(num1, Math.Max(num2,num3))}");
            Console.WriteLine($"Lowest number: {Math.Min(num1, Math.Min(num2, num3))}");
            Console.ReadKey();
        }
    }
}
