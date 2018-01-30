using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del array deseado");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayTreatment at = new ArrayTreatment();
            at.FillArray1(size);
            at.FillArray2(size);
            
            foreach (int item in at.ArrayMultiplier())
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();

        }
        
        
    }
}
