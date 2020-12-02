using Sudoku;
using System;
using System.Collections.Generic;

namespace ValidationSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] {
                { 1, 2, 3,  4, 5, 6,  7, 8, 9 },
                { 2, 3, 4,  5, 7, 7,  8, 9, 1 },
                { 3, 4, 5,  6, 7, 8,  9, 1, 2 },
                                     
                { 4, 5, 6,  7, 8, 9,  1, 2, 3 },
                { 5, 6, 7,  8, 9, 1,  2, 3, 4 },
                { 6, 7, 8,  9, 1, 2,  3, 4, 5 },
                                     
                { 7, 8, 9,  1, 2, 3,  4, 5, 6 },
                { 8, 9, 1,  2, 3, 4,  5, 6, 7 },
                { 9, 1, 2,  3, 4, 5,  6, 7, 8 } };

                var result = SudokuValidator.Validate(arr);
                if (result.isValid)
                    Console.WriteLine("Sudoku is valid");
                else
                    Console.WriteLine(result.message);
            }
        }
    }
}
