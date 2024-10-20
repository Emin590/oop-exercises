using System;

class sudokuSolver
{
    static int[,] sudokuBoard = new int[9, 9] {
        {1, 0, 0, 4, 8, 9, 0, 0, 6},
        {7, 3, 0, 0, 0, 0, 0, 4, 0},
        {0, 0, 0, 0, 0, 1, 2, 9, 5},
        {0, 0, 7, 1, 2, 0, 6, 0, 0},
        {5, 0, 0, 7, 0, 3, 0, 0, 8},
        {0, 0, 6, 0, 9, 5, 7, 0, 0},
        {9, 1, 4, 6, 0, 0, 0, 0, 0},
        {0, 2, 0, 0, 0, 0, 0, 3, 7},
        {8, 0, 0, 5, 1, 2, 0, 0, 4}
    };

    static bool[,] tfBoard = new bool[9, 9];

    static bool CheckRows(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            bool[] seen = new bool[9]; // Track numbers 1-9

            for (int j = 0; j < 9; j++)
            {
                int num = board[i, j];
                if (num != 0) // Ignore 0
                {
                    if (seen[num - 1]) // Check for duplicates
                    {
                        return false;
                    }
                    seen[num - 1] = true; // Mark this number as seen
                }
            }
        }
        return true;
    }

    static bool CheckColumns(int[,] board)
    {
        for (int j = 0; j < 9; j++)
        {
            bool[] seen = new bool[9]; // Track numbers 1-9
            for (int i = 0; i < 9; i++)
            {
                int num = board[i, j];
                if (num != 0) // Ignore 0
                {
                    if (seen[num - 1]) // Check for duplicates
                    {
                        return false;
                    }
                    seen[num - 1] = true; // Mark this number as seen
                }
            }
        }
        return true;
    }

    static bool CheckBoxes(int[,] board)
    {
        for (int boxRow = 0; boxRow < 3; boxRow++)
        {
            for (int boxCol = 0; boxCol < 3; boxCol++)
            {
                bool[] seen = new bool[9]; // Track numbers 1-9
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int num = board[boxRow * 3 + i, boxCol * 3 + j];
                        if (num != 0) // Ignore 0
                        {
                            if (seen[num - 1]) // Check for duplicates
                            {
                                return false;
                            }
                            seen[num - 1] = true; // Mark this number as seen
                        }
                    }
                }
            }
        }
        return true;
    }

    static void filltfBoard()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int k = 0; k < 9; k++)
            {
                tfBoard[i, k] = sudokuBoard[i, k] > 0; // Mark true if filled
            }
        }
    }

    static void printer(int[,] board)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int k = 0; k < 9; k++)
            {
                Console.Write(board[i, k] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool SolveSudoku(int[,] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row, col] == 0) // Find an empty cell
                {
                    for (int num = 1; num <= 9; num++) // Try numbers 1-9
                    {
                        board[row, col] = num; // Place the number

                        // Check if placing the number is valid
                        if (CheckBoxes(board) && CheckColumns(board) && CheckRows(board))
                        {
                            // Recur to see if we can fill the rest
                            if (SolveSudoku(board))
                            {
                                return true; // Solution found
                            }
                        }
                        // Reset if not valid
                        board[row, col] = 0; 
                    }
                    return false; // Trigger backtracking
                }
            }
        }
        return true; // Solved
    }

    static void Main(string[] args)
    {
        filltfBoard();
        Console.WriteLine("Initial Sudoku Board:");
        printer(sudokuBoard);
        Console.WriteLine();
        
        if (SolveSudoku(sudokuBoard))
        {
            Console.WriteLine("Solved Sudoku Board:");
            printer(sudokuBoard);
        }
        else
        {
            Console.WriteLine("No solution exists.");
        }
    }
}
