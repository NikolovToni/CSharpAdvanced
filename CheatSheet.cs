/////////////////////////////////////////////////
// Multidimensional array 
/////////////////////////////////////////////////

            int[] rowsAndColumns = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = rowsAndColumns[0];
            int cols = rowsAndColumns[1];

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}, ");
                }

                Console.WriteLine();
            }

/////////////////////////////////////////////////
// Jagged-array 
/////////////////////////////////////////////////

            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                arr[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    arr[i][j] = numbers[j];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }