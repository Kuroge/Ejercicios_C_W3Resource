using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowMax = 5;
            int colMax = 3;

            for (int row = 1; row <= rowMax; row++)
            {
                for (int col = 1; col <= colMax; col++)
                {
                    if (row == 1 || row == rowMax)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (col == 1 || col == colMax)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
