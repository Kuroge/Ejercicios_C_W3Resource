using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            ClasArrayOdd oddArray = new ClasArrayOdd(array);
            Console.WriteLine(oddArray.CheckOdd());
            Console.ReadKey();
        }
    }
}
