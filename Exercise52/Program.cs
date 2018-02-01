using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 5 };
            int[] array2 = new int[] { 0, 3, 8 };
            int[] array3 = new int[] { -1, 0, 2 };
            int[] newarray = new int[] { array[1], array2[1], array3[1] };
            Console.WriteLine(string.Join(",", newarray));
            Console.ReadKey();
        }
    }
}
