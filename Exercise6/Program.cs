using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("Por favor introduce el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el tercero número");
            num3 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2 * num3;
            Console.WriteLine($"El resultado de la multiplicación es: {result}");
            Console.ReadKey();
        }
    }
}
