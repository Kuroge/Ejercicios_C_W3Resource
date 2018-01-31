using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise37
{
    class ClassHP
    {
        public string Phrase { get; set; }

        public ClassHP(string phrase)
        {
            Phrase = phrase;
        }
        public string CheckHP()
        {
            if (Phrase.Substring(1, 2).ToLower().Equals("hp"))
            {
                return Phrase.Substring(0, 1) + Phrase.Substring(3);
            }
            else
            {
                return Phrase;
            }
        }
    }
}
