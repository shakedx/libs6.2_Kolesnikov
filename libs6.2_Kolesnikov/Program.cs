﻿using System;

namespace libs6._2_Kolesnikov
{
    class Program
    {
        static void Main()
        {
            //5.2 - базовый
            int[,] mas = new int[7, 5];
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    mas[i, j] = rnd.Next(-10, 11);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int res = MyLib.ClassLib.SumNegative(mas);

        }
    }
}
