using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0 && num2 > 0 || num1 > 0 && num2 < 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();

        }
    }
}
