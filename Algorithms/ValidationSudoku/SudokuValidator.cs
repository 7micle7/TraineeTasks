using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    public class SudokuValidator
    {
        private static void CheckRows(int[,] arr)
        {
            var uniqueCollection = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var item = arr[i, j];
                    if (uniqueCollection.Contains(item))
                    {
                        throw new SudokuValidationException($"Duplicate in row:{i}, column:{j}");
                    }
                    uniqueCollection.Add(item);
                }
                uniqueCollection.Clear();
            }
        }

        private static void CheckColumns(int[,] arr)
        {
            var uniqueCollection = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    var item = arr[j, i];
                    if (uniqueCollection.Contains(item))
                    {
                        throw new SudokuValidationException($"Duplicate in row:{i}, column:{j}");
                    }
                    uniqueCollection.Add(item);
                }
                uniqueCollection.Clear();
            }
        }

        private static void CheckSubsquares(int[,] arr)
        {
            var uniqueCollection = new List<int>();
            int step = (int)Math.Sqrt(arr.GetLength(0));
            for (int row = 0; row < arr.GetLength(0); row = row + step)
                for (int col = 0; col < arr.GetLength(1); col = col + step)
                    for (int i = row; i < row + step; i++)
                        for (int j = col; j < col + step; j++)
                        {
                            var item = arr[j, i];
                            if (uniqueCollection.Contains(item))
                            {
                                throw new SudokuValidationException($"Duplicate in subsquare");
                            }
                            uniqueCollection.Add(item);
                        }

        }

        public static (bool isValid, string message) Validate(int[,] arr)
        {
            try
            {
                CheckRows(arr);
                CheckColumns(arr);
                CheckSubsquares(arr);

                return (true, null);
            }
            catch (SudokuValidationException ex)
            {
                return (false, ex.Message);
            };
        }
    }
}
