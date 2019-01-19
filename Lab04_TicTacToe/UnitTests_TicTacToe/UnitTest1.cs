using Lab04_TicTacToe.Classes;
using System;
using Xunit;

namespace UnitTests_TicTacToe
{
    public class UnitTest1
    {
        [Fact]
        public void CheckForWinnerCanReturnFalse()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            Board testBoard = new Board();

            Assert.False(testGame.CheckForWinner(testBoard));
        }
    }
}
