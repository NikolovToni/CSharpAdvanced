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

<<<<<<< HEAD
            int matrixRows = inputLine[0];
            int matrixCols = inputLine[1];

            int[,] matrix = new int[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
=======
            int rows = inputLine[0];
            int cols = inputLine[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
>>>>>>> 860d254b5237bb102b10778083f8854bd5e8edbb
            {
                int[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
<<<<<<< HEAD
                for (int col = 0; col < matrixCols; col++)
                {   
                    matrix[matrixRows, matrixCols] = line[col];
                }
            }


=======
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            int sumMatrix = 0;
            foreach (var number in matrix)
            {
                sumMatrix += number;
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sumMatrix);
>>>>>>> 860d254b5237bb102b10778083f8854bd5e8edbb
        }
    }
}
