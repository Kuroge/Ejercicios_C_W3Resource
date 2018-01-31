using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string phrase = Console.ReadLine();
            ClasCountW countw = new ClasCountW(phrase);
            Console.WriteLine(countw.CheckW());
            Console.ReadKey();
        }
    }
}
