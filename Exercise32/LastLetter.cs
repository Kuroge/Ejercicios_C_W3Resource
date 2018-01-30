using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32
{
    public class LastLetter
    {
        private string Phrase { get; set; }

        public LastLetter(string phrase)
        {
            Phrase = phrase;
        }

        public string LastFourLetters()
        {

            if (this.Validate())
            {

                //for (int i = Phrase.Length - 4; i <= Phrase.Length - 1; i++)
                //{
                //    LastFour += Phrase[i];
                //}
                //LastFour = LastFour + LastFour + LastFour + LastFour;
                string LastFour = this.Phrase.Substring(this.Phrase.Length - 4);
                return LastFour + LastFour + LastFour + LastFour;
            }
            else
                return string.Empty;

        }
        private bool Validate()
        {
            if (Phrase.Length < 4)
            {
                Console.WriteLine("La palabra debe contener al menos 4 caracteres");
                return false;
            }
            else
            {
                Console.WriteLine("Comprobación correcta. La frase cumple los requisitos");
                return true;
            }
        }
    }
}
