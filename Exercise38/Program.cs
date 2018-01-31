using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string phrase = Console.ReadLine();
            ClassHP hptest = new ClassHP(phrase);
            Console.WriteLine(hptest.CheckHP());
            Console.ReadKey();
        }
    }
}
