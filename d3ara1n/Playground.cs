using System;

namespace NineNineTable
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{0}*{1}={2}" + j != 9 ? " " : "", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}