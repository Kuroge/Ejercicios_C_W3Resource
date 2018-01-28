using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if (i%2 == 0)
                {
                    for (int p = 0; p < 4; p++)
                    {
                        Console.Write("25 ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int p = 0; p < 4; p++)
                    {
                        Console.Write("25");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
