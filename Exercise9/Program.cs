using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el tercer número");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el cuarto número");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La media de los cuatro número es: {Average(num1,num2,num3,num4)}");
            Console.ReadKey();

        }
        static int Average(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        }
    }
}
