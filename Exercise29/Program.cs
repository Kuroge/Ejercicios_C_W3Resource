using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la ruta del archivo del que quieres saber el tamaño");
            string s = Console.ReadLine();
            FileInfo f = new FileInfo(s);
            Console.WriteLine($"El tamaño del archivo es de: {f.Length} bytes");
            Console.ReadKey();
        }
    }
}
