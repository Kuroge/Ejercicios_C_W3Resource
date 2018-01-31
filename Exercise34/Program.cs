using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep;
            do
            {
                rep = false;
                Console.WriteLine("Introduce una frase");
                string input = Console.ReadLine();
                ClassWord frase = new ClassWord(input);
                Console.WriteLine("Introduce la palabra a comprobar");
                string palabra = Console.ReadLine();
                frase.ComprobarPalabra(palabra);
                Console.WriteLine("¿Quieres comprobar otra frase? y/n");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer.Equals('y'))
                {
                    rep = true;
                }
            } while (rep);

        }
    }
}
