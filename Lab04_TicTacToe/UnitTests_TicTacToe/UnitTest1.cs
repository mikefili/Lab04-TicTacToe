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

        [Fact]
        public void CanSwitchToPlayerOne()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            testOne.IsTurn = true;
            testTwo.IsTurn = false;
            testGame.SwitchPlayer();

            Assert.True(testTwo.IsTurn);
        }

        [Fact]
        public void CanSwitchToPlayerTwo()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            testOne.IsTurn = false;
            testTwo.IsTurn = true;
            testGame.SwitchPlayer();

            Assert.False(testTwo.IsTurn);
        }
    }
}
