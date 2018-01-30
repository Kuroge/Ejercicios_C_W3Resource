using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra");
            string s = Console.ReadLine();

            char firstLetter = s[0];
            char lastLetter = s[s.Length - 1];

            string[] swapArray = new string[s.Length];
            swapArray[0] = lastLetter.ToString();
            swapArray[swapArray.Length - 1] = firstLetter.ToString();

            for (int i = 1; i < swapArray.Length-1; i++)
            {
                swapArray[i] = s[i].ToString();
            }
            foreach (var i in swapArray)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
