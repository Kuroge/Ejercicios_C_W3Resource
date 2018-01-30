using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase");
            string input = Console.ReadLine();
            ReverseWord(input);
            Console.ReadKey();

        }
        public static void ReverseWord(string s)
        {
            string[] normal = new string[s.Length];
            normal = s.Split(' ');
            StringBuilder reverse = new StringBuilder();
            for (int i = normal.Length-1; i >= 0; i--)
            {
                reverse.Append(normal[i]+" ");
            }
            
            Console.WriteLine(reverse.ToString());

        }
    }
}
