using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainGame.TrainParts;

namespace TrainGame
{
    public class Game
    {
        public bool GameState = true;

        public void LooseGame()
        {
            GameState = false;
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void WinGame()
        {
            GameState = false;
            MessageBox.Show("You win!", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
