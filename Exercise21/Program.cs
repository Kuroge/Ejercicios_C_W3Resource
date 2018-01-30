using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(TwentyTrue(num1,num2));
            Console.ReadKey();

        }
        public static bool TwentyTrue(int num1, int num2)
        {
            return num1 == 20 || num2 == 20 || (num1 + num2) == 20 ? true : false;
        }
    }
}
