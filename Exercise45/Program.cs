using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[] { 1,3,4,5,6,7,8,4,3,2,5,4,2,6,7,8,9,5,4,3,2,1,5,6,7,6,4,5,3,2,1};
            int ctr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input)
                {
                    ctr++;
                }
            }
            Console.WriteLine($"El número {input} aparece {ctr} veces");
            Console.ReadKey();
        }
    }
}
