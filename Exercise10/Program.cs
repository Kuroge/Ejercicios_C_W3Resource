using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
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
            Console.WriteLine($"El reusltado de los números {num1},{num2} y {num3} en la operación (x+y)*z es: {(num1+num2)*num3} y en la operación x*y+y*z es: {num1*num2+num2*num3}");
            Console.ReadKey();
        }
    }
}
