using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Suma total: {sum}");
            Console.ReadKey();
        }
    }
}
