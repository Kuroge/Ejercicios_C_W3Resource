using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Within(num1));
            Console.ReadKey();
        }
        public static bool Within(int num)
        {
            return Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10 ? true : false;
        }
    }
}
