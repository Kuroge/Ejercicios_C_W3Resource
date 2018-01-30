using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string s = Console.ReadLine();
            Console.WriteLine(s.ToLower());
            Console.ReadKey();
        }
    }
}
