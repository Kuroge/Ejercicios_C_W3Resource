using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string input = Console.ReadLine();
            LastLetter lt = new LastLetter(input);
            var LastFour = lt.LastFourLetters();
            Console.WriteLine(LastFour);
            Console.ReadKey();
        }
    }
}
