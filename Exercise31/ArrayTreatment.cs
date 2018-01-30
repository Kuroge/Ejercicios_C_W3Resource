using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    public class ArrayTreatment
    {

        public int[] Array1 { get; set; }

        public int[] Array2 { get; set; }


        public int[] ArrayMultiplier()
        {
            int[] finalArray = new int[Array1.Length];
            for (int i = 0; i <= Array1.Length - 1; i++)
            {
                finalArray[i] = Array1[i] * Array2[i];
            }
            return finalArray;
        }
        private int[] FillArray(int size, int number)
        {
            int[] intArray = new int[size];
            for (int i = 0; i <= size - 1; i++)
            {
                Console.WriteLine("Introduce el valor {0} del {1} array", i, number == 1 ? "primer" : "segundo");
                intArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            return intArray;
        }

        public void FillArray1(int size)
        {
            this.Array1 = this.FillArray(size, 1);
        }

        public void FillArray2(int size)
        {
            this.Array2 = this.FillArray(size, 2);
        }
    }
}
