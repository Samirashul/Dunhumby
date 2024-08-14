using Dunnhumby;

namespace DunnhumbyTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestNonNumericEntry()
        {
            Board gameBoard = new Board();

            Assert.AreEqual(10, gameBoard.GetNextKey("a"));

        }

        [TestMethod]
        public void TestNonEmptySpace()
        {
            Board gameBoard = new Board();

            gameBoard.board[0] = "X";


            Assert.AreEqual(9, gameBoard.GetNextKey("1"));

        }

        [TestMethod]
        public void TestEntry()
        {
            Board gameBoard = new Board();

            string[] expected = ["X", "-", "-", "-", "-", "-", "-", "-", "-"];

            gameBoard.addEntry(0);

            CollectionAssert.AreEqual(expected, gameBoard.board);

        }

        [TestMethod]
        public void TestVictory()
        {
            Board gameBoard = new Board();

            gameBoard.board = ["X", "X", "-", "-", "-", "-", "-", "-", "-"];

            Assert.IsTrue(gameBoard.addEntry(2));

        }

        [TestMethod]
        public void TestWinningMove()
        {
            Board gameBoard = new Board();

            gameBoard.board = ["X", "X", "X", "X", "X", "X", "X", "X", "X"];

            Assert.IsTrue(gameBoard.CheckWin("X"));

        }

        [TestMethod]
        public void TestNonWinningMove()
        {
            Board gameBoard = new Board();

            Assert.IsFalse(gameBoard.addEntry(0));

        }
    }
}