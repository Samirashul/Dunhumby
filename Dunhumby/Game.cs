using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunnhumby
{
    public class Game
    {
        private Grid grid = new Grid();
        private InputHandler inputHandler = new InputHandler();
        private TurnController turnController = new TurnController();
        private NameHandler nameHandler = new NameHandler();

        static void Main(string[] args)
        {
            Game game = new Game();

            Console.WriteLine("Player X, type in your name and press the Enter key:");
            string x = game.nameHandler.GetName();
            Console.Clear();
            Console.WriteLine("Player O, type in your name and press the Enter key:");
            string o = game.nameHandler.GetName();
            game.grid.Show();
            do
            {
                game.grid.Write(game.turnController.GetTurn(), game.inputHandler.GetNextKey(game.grid.GetGrid()));
                game.grid.Show();
            }
            while (!game.turnController.NextTurn(game.grid, x, o));
        }
    }
}
