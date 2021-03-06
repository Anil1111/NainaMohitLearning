﻿using System;

namespace DataStructures
{
    public static class MyArrayExtesions
    {
        public static void Swap<T>(this T[] array, int pos1, int pos2)
        {
            T temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        public static void Print<T>(this T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void Print<T>(this T[] array, int maxLimit)
        {
            for (int i = 0; i < maxLimit; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Print<T>(this T[] array, int index1, int index2)
        {
            for (int i = index1; i <= index2; i++)
            {
                Console.WriteLine(array[i] +" ");
            }
            Console.WriteLine();
        }
    }
}
