using System;

namespace Sudoku
{
    public class SudokuValidationException : Exception
    {
        public SudokuValidationException(string message) : base(message) { }
    }
}
