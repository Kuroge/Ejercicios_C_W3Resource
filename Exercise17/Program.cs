using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra");
            string s = Console.ReadLine();
            Console.WriteLine($"{s[0]}{s}{s[0]}");
            Console.ReadKey();
        }
    }
}
