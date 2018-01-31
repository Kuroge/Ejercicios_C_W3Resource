using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string phrase = Console.ReadLine();
            string oddphrase = string.Empty;
            for (int i = 0; i < phrase.Length; i++)
            {
                if ((i+1)%2 != 0)
                {
                    oddphrase += phrase[i];
                }
            }
            Console.WriteLine(oddphrase);
            Console.ReadKey();
        }
    }
}
