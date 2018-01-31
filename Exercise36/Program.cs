using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            ClassNumbers numbers = new ClassNumbers(num1, num2);
            Console.WriteLine(numbers.CheckNumbers());
            Console.ReadKey();
        }
    }
}
