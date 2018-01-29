using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la palabra");
            string input = Console.ReadLine();
            Console.WriteLine("Introduce la letra a eliminar. El index empieza en 1");
            int index = Convert.ToInt32(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            int i = 1;
            foreach (char c in input)
            {
                if (i != index)
                {
                    result.Append(c);
                }
                i++;
            }            
            Console.WriteLine(result.ToString());
            Console.ReadKey();

        }
    }
}
