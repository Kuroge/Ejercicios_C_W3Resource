using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string phrase = Console.ReadLine();
            if (phrase.Length < 4)
            {
                Console.WriteLine(phrase.ToUpper());
            }
            else
            {
                Console.WriteLine(phrase.Substring(0,4).ToLower()+phrase.Substring(4));
            }
            Console.ReadKey();
        }
    }
}
