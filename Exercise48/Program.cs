﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor introduce el tamaño del array deseado");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Introduce el valor {i+1}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(array[0] == array[array.Length-1] && array.Length >= 1 ? true : false);
            Console.ReadKey();
        }
    }
}
