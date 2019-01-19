using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
        /// <summary>
        /// Tic Tac Toe Game board states
        /// </summary>
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        /// <summary>
        /// Layout Tic Tac Toe Game board
        /// </summary>
        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("     ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" |{GameBoard[i, j]}|");
                }
                Console.WriteLine();
                //TODO: Output the board to the console
            }
        }
    }
}