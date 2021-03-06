using Lab04_TicTacToe.Classes;
using System;
using Xunit;

namespace UnitTests_TicTacToe
{
    public class UnitTest1
    {
        [Fact]
        static void CanCreateGameBoard()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game game = new Game(testOne, testTwo);
            string[,] expected = new string[,]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            Assert.Equal(expected, game.Board.GameBoard);
        }

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
        public void CheckForWinnerCanReturnTrue()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            testGame.Board.GameBoard = new string[,]
            {
                {"X", "X", "X"},
                {"X", "X", "X"},
                {"X", "X", "X"},
            };
            Assert.True(testGame.CheckForWinner(testGame.Board));
        }

        [Fact]
        public void CanSwitchToPlayerOne()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            testOne.Turn = true;
            testTwo.Turn = false;
            testGame.SwitchPlayer();

            Assert.True(testTwo.Turn);
        }

        [Fact]
        public void CanSwitchToPlayerTwo()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
            testOne.Turn = false;
            testTwo.Turn = true;
            testGame.SwitchPlayer();

            Assert.False(testTwo.Turn);
        }

        [Theory]
        [InlineData("1", new[] { 0, 0 })]
        [InlineData("2", new[] { 0, 1 })]
        [InlineData("3", new[] { 0, 2 })]
        [InlineData("4", new[] { 1, 0 })]
        [InlineData("5", new[] { 1, 1 })]
        [InlineData("6", new[] { 1, 2 })]
        [InlineData("7", new[] { 2, 0 })]
        [InlineData("8", new[] { 2, 1 })]
        [InlineData("9", new[] { 2, 2 })]
        public void CanPlaceMarkerOnCorrectRow(string userInput, int[] expected)
        {
            Position marker = new Position(expected[0], expected[1]);
            Position input = Player.NumberPositions(Convert.ToInt32(userInput));

            Assert.Equal(marker.Row, input.Row);
        }

        [Theory]
        [InlineData("1", new[] { 0, 0 })]
        [InlineData("2", new[] { 0, 1 })]
        [InlineData("3", new[] { 0, 2 })]
        [InlineData("4", new[] { 1, 0 })]
        [InlineData("5", new[] { 1, 1 })]
        [InlineData("6", new[] { 1, 2 })]
        [InlineData("7", new[] { 2, 0 })]
        [InlineData("8", new[] { 2, 1 })]
        [InlineData("9", new[] { 2, 2 })]
        public void CanPlaceMarkerOnCorrectColumn(string userInput, int[] expected)
        {
            Position marker = new Position(expected[0], expected[1]);
            Position input = Player.NumberPositions(Convert.ToInt32(userInput));

            Assert.Equal(marker.Column, input.Column);
        }

        [Fact]
        public void CanPlayGame()
        {
            Player testOne = new Player();
            Player testTwo = new Player();
            Game testGame = new Game(testOne, testTwo);
        }
    }
}
