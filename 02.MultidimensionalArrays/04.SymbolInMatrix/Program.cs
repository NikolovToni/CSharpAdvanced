using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isThere = true;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (symbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                    else
                    {
                        isThere = false;
                    }
                }
            }

            if (isThere == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
