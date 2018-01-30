using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr = 0;
            int n = 2;
            long sum = 0;
            while (ctr < 784)
            {
                if (EsPrimo(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }
            Console.WriteLine($"La suma de los primeros 500 números primos es: {sum}");
            Console.WriteLine(14 % 10);
            Console.ReadKey();
            
          
        
       
        }
        public static bool EsPrimo(int i)
        {
            int square = Convert.ToInt32(Math.Floor(Math.Sqrt(i)));
            if (i == 1) return false;
            if (i == 2) return true;
            if (i % 2 == 0) return false;
            for (int c = 3; c <= square; c+=2)
            {
                if (i % c == 0) return false;
            }
            return true;

        }
    }
}
