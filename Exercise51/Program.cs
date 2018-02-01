using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int mayor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1} del array");
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] > mayor)
                {
                    mayor = array[i];
                }
            }
            Console.WriteLine($"El número mayor es {mayor}");
            Console.ReadKey();

        }
    }
}
