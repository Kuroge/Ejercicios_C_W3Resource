using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TripleSum(num1,num2));
            Console.ReadKey();

        }
        public static int TripleSum(int num1, int num2)
        {
            return num1 == num2 ? (num1 + num2) * 3 : num1 + num2;
        }
    }
}
