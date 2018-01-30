using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número hexadecimal");
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine($"El valor decimal de {hex} es: {dec}");
            Console.ReadKey();
        }
    }
}
