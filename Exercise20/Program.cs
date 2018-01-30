using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DoubleSum(num1,num2));
            Console.ReadKey();

        }
        public static int DoubleSum(int num1,int num2)
        {
            return num1 > num2 ? Math.Abs((num1 - num2) * 2) : Math.Abs(num1 - num2);
        }
    }
}
