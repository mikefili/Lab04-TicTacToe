using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Game
	{
		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }
		public Player Winner { get; set; }
		public Board Board { get; set; }


		/// <summary>
		/// Require 2 players and a board to start a game. 
		/// </summary>
		/// <param name="p1">Player 1</param>
		/// <param name="p2">Player 2</param>
		public Game(Player p1, Player p2)
		{
			PlayerOne = p1;
			PlayerTwo = p2;
			Board = new Board();
		}

		/// <summary>
		/// Begin game
		/// </summary>
		/// <returns>Winner</returns>
		public Player Play()
		{
            PlayerOne.Name = "Player 1";
            PlayerTwo.Name = "Player 2";
            PlayerOne.Marker = "X";
            PlayerTwo.Marker = "O";
            PlayerOne.Turn = true;
            PlayerTwo.Turn = false;

            int turns = 0;
            bool winner = false;
            while (winner == false && turns < 9)
                {
                Console.WriteLine();
                Board.DisplayBoard();
                NextPlayer().TakeTurn(Board);
                winner = CheckForWinner(Board);
                turns++;
                SwitchPlayer();
                }
            if (turns == 9)
            {
                Console.WriteLine("You drew!");
            }
            Console.ReadLine();
            return null;
        }


		/// <summary>
		/// Check if there is a winner
		/// </summary>
		/// <param name="board">current game board</param>
		/// <returns>bool</returns>
		public bool CheckForWinner(Board board)
		{
			int[][] winners = new int[][]
			{
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

				new[] {1,5,9},
				new[] {3,5,7}
			};

			// Confirm winner found & congratulate the winner
			for (int i = 0; i < winners.Length; i++)
			{
				Position p1 = Player.NumberPositions(winners[i][0]);
				Position p2 = Player.NumberPositions(winners[i][1]);
				Position p3 = Player.NumberPositions(winners[i][2]);
				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column]; 

                if (a == "X" && b == "X" && c == "X")
                {
                    Console.WriteLine("Congrats, Player One!");
                    Console.Write("You win!");
                    return true;
                }
                else if (a == "O" && b == "O" && c == "O")
                {
                    Console.WriteLine("Congrats, Player Two!");
                    Console.Write("You win!");
                    return true;
                }
			}

			return false;
		}


		/// <summary>
		/// Determine who goes next
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerOne.Turn) ? PlayerOne : PlayerTwo;
		}

		/// <summary>
		/// Switch to next player
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerOne.Turn)
			{
				PlayerOne.Turn = false;
				PlayerTwo.Turn = true;
			}
			else
			{
				PlayerOne.Turn = true;
				PlayerTwo.Turn = false;
			}
		}


	}
}
