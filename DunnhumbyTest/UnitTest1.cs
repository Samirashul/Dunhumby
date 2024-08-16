using Dunnhumby;

namespace DunnhumbyTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestNonNumericEntry()
        {
            InputHandler inputHandler = new InputHandler();

            Assert.AreEqual(10, inputHandler.GetNextKey("a"));

        }

        [TestMethod]
        public void TestNonEmptySpace()
        {
            Grid gameBoard = new Grid();

            gameBoard.board[0] = "X";


            Assert.AreEqual(9, gameBoard.GetNextKey("1"));

        }

        [TestMethod]
        public void TestEntry()
        {
            Grid gameBoard = new Grid();

            string[] expected = ["X", "-", "-", "-", "-", "-", "-", "-", "-"];

            gameBoard.addEntry(0);

            CollectionAssert.AreEqual(expected, gameBoard.board);

        }

        [TestMethod]
        public void TestVictory()
        {
            Grid gameBoard = new Grid();

            gameBoard.board = ["X", "X", "-", "-", "-", "-", "-", "-", "-"];

            Assert.IsTrue(gameBoard.addEntry(2));

        }

        [TestMethod]
        public void TestWinningMove()
        {
            Grid gameBoard = new Grid();

            gameBoard.board = ["X", "X", "X", "X", "X", "X", "X", "X", "X"];

            Assert.IsTrue(gameBoard.CheckWin("X"));

        }

        [TestMethod]
        public void TestNonWinningMove()
        {
            Grid gameBoard = new Grid();

            Assert.IsFalse(gameBoard.addEntry(0));

        }
    }
}