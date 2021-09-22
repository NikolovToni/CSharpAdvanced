using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matrixRows = inputLine[0];
            int matrixCols = inputLine[1];

            int[,] matrix = new int[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrixCols; col++)
                {   
                    matrix[matrixRows, matrixCols] = line[col];
                }
            }


        }
    }
}
