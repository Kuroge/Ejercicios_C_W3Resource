using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Por favor introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            temp = num2;
            num2 = num1;
            num1 = temp;
            Console.WriteLine($"Tras el cambio el primer dígito es {num1} y el segundo vale {num2}");
            Console.ReadKey();

        }
    }
}
