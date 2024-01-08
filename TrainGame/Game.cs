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

        public void EndGame()
        {
            GameState = false;
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
