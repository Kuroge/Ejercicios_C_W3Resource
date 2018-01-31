using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38
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
            if (Phrase.Substring(0, 2).ToLower().Equals("ph"))
            {
                return Phrase.Substring(0,2);
            }
            else
            {
                return Phrase;
            }
        }
    }
}
