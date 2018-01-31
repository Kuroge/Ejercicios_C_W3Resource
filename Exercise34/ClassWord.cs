using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34
{
    class ClassWord
    {
        public string[] Word { get; private set; }

        public ClassWord(string word)
        {
            Word = word.Split(' ');
        }

        public void ComprobarPalabra(string palabra)
        {
            if (Word[0].ToLower().Equals(palabra))
            {
                Console.WriteLine("La frase empieza por la palabra indicada");
            }
            else
            {
                Console.WriteLine("La frase no empieza por la palabra indicada");
            }
        }
    }
}
