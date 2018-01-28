using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, rest, mult, div, mod;
            Console.WriteLine("Introduce el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            rest = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {rest}");
            Console.WriteLine($"{num1} * {num2} = {mult}");
            Console.WriteLine($"{num1} / {num2} = {div}");
            Console.WriteLine($"{num1} % {num2} = {mod}");
            Console.ReadKey();
        }
    }
}
