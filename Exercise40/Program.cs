using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res1 = Math.Abs(num1 - x);
            int res2 = Math.Abs(num2 - x);


            Console.WriteLine(num1 == num2 ? 0 : (num1 > num2 ? num1 : num2));
            Console.ReadKey();
        }
    }
}
