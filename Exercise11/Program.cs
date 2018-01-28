using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Pareces mayor de {edad}");
            Console.ReadKey();
        }
    }
}
