using System;

namespace MyLib
{
    public class ClassLib
    {
        public static int SumNegative(int[,] mas)
        {
            int max = mas[0, 0];
            int min = mas[0, 0];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mas[i, j] > max)
                        max = mas[i, j];
                    if (mas[i, j] < min)
                        min = mas[i, j];
                }
            }
            Console.WriteLine("Максимальное: {0}", max);
            Console.WriteLine("Минимальное: {0}", min);
            Console.ReadKey();
            return max;

        }

    }
}
