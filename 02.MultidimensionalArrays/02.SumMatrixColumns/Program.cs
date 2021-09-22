using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = inputLine[0];
            int cols = inputLine[1];

            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int sumColumns = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    sumColumns += matrix[row, col];
                }

                Console.WriteLine(sumColumns);
            }
        }
    }
}
