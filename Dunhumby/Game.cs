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
        private GameController gameController = new GameController();

        static void Main(string[] args)
        {
            Game game = new Game();
            game.grid.Show();
            do
            {
                game.grid.Write(game.gameController.GetTurn(), game.inputHandler.GetNextKey(game.grid.getGrid()));
                game.grid.Show();
            }
            while (!game.gameController.NextTurn(game.grid.getGrid()));
        }
    }
}
