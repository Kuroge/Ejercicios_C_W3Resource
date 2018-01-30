using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want the even or the odd numbers?");
            string input = Console.ReadLine();
            EvenOrOdd(input);
            Console.ReadKey();

        }
        public static void EvenOrOdd(string input)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (input.ToLower().Equals("even") && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                if (input.ToLower().Equals("odd") && i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
