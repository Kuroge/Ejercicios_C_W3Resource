using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41
{
    class ClasCountW
    {
        public string Phrase { get; set; }

        public ClasCountW(string phrase)
        {
            Phrase = phrase;
        }
        public bool CheckW()
        {
            bool answer = false;
            int wcount = 0;
            for (int i = 0; i < Phrase.Length; i++)
            {
                if (Phrase[i] == 'w')
                {
                    answer = true;
                    wcount++;
                    if (wcount > 3)
                    {
                        answer = false;
                    }
                    

                    
                }
               
            }
            return answer;
        }
    }
}
