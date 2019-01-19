using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("  L E T ' S   P L A Y");
            Console.WriteLine();
            Console.WriteLine("       T   I   C");
            Console.WriteLine("       T   A   C");
            Console.WriteLine("       T   O   E");
            Player first  = new Player();
            Player p2 = new Player();
            Game game = new Game (p2, first);
            game.Play();
        }
    }
}
