using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 4, 2, 3, 4, 5, 5 };
            Console.WriteLine("Introduce un número");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((array[0] == num || array[array.Length - 1] == num));
            Console.ReadKey();
        }
    }
}
