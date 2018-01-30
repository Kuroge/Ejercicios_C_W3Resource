using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Numb = false;
            do
            {
                Console.WriteLine("Introduce el número a comprobar");
                int number = Convert.ToInt32(Console.ReadLine());
                ArrayList Multiplos = new ArrayList();
                bool Mult = false;
                
                do
                {
                    Console.WriteLine("Introduce un número para comprobar si es multiplo");
                    Multiplos.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("¿Quieres añadir otro posible multiplo? y/n");
                    char yn2 = Convert.ToChar(Console.ReadLine());
                    if (yn2.Equals('y'))
                    {
                        Mult = true;
                    }
                    else
                    {
                        Mult = false;
                    }
                } while (Mult);
                Numbers nmb = new Numbers(number,Multiplos);
                nmb.EsMultiplo();
                Console.WriteLine("¿Quieres comprobar otro número? y/n");
                char yn1 = Convert.ToChar(Console.ReadLine());
                if (yn1.Equals('y'))
                {
                    Numb = true;
                }
                else
                {
                    Numb = false;
                }
            } while (Numb);
        }
    }
}
