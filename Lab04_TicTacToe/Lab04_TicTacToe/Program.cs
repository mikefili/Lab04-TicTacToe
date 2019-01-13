using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello shitty game");
            Player first  = new Player();
            Player p2 = new Player();
            Game game = new Game (p2, first);
            game.Play();
        }
    }
}
