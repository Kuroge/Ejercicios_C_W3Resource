using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33
{
    class Numbers
    {
        public int number { get; set; }

        public ArrayList Multiplos { get; set; }

        public Numbers(int input, ArrayList iMultiplos)
        {
            number = input;
            Multiplos = iMultiplos;
        }

        public void EsMultiplo()
        {
            foreach (int item in this.Multiplos)
            {
                if (number % item == 0)
                {
                    Console.WriteLine($"{number} es multiplo de {item}");
                }
                else
                {
                    Console.WriteLine($"{number} no es multiplo de {item}");
                }
            }
        }
    }
}
