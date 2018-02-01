using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 8 };
            int[] arrayleft = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0) 
                {
                    arrayleft[array.Length - 1] = array[i];
                }
                else
                {
                    arrayleft[i - 1] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(arrayleft[i]);
            }
            Console.ReadKey();
        }
    }
}
