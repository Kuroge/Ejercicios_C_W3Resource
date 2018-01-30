using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string input = Console.ReadLine();
            Console.WriteLine(LongestWord(input));
            Console.ReadKey();

        }
        public static string LongestWord(string s)
        {
            string longest = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }
            return longest;
        }

    }
}
