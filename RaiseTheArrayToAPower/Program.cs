﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RaiseTheArrayToAPower
{
    internal class Program
    {
        static void Main()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            Console.WriteLine(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            Console.WriteLine(GetPoweredArray(arrayToPower, 2));
            Console.WriteLine(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            Console.WriteLine(GetPoweredArray(new int[0], 1));
            Console.WriteLine(GetPoweredArray(new[] { 42 }, 0));


        }
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] arr1 = arr;
            for (int i = 0; i < arr1.Length; i++)
                arr[i] = Convert.ToInt32(Math.Pow(arr1[i], power));
            return arr1;
        }

    }
}
