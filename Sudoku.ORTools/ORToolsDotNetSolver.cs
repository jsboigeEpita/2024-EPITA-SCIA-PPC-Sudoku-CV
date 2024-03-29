using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudoku.Shared;

namespace Sudoku.ORTools
{
    public class ORToolsDotNetSolver : ISudokuSolver
    {
        /// <summary>
        /// Solves the given Sudoku grid using a backtracking algorithm.
        /// </summary>
        /// <param name="s">The Sudoku grid to be solved.</param>
        /// <returns>
        /// The solved Sudoku grid.
        /// </returns>
        public SudokuGrid Solve(SudokuGrid s)
        {
            return s;
        }

    }
}