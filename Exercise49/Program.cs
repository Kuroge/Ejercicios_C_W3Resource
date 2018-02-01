using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indica el tamaño de los arrays");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Introduce el valor {i} del array1");
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine($"Introduce el valor {i} del array2");
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine((array1[0] == array2[0] && array1.Length-1 >= 1) || (array1[size-1] == array2[size-1] && array1.Length - 1 >= 1) ? true : false);
            Console.ReadKey();
        }
    }
}
