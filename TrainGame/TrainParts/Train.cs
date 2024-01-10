using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using TrainGame.TrainParts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TrainGame.TrainParts
{

    public class Train : MovingObjects
    {
        public const string TrainImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\train.png";
        public const string RotatedTrainImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\RotatedTrain1.png";

        public Train(PictureBox pictureBox) : base(pictureBox, 200, 325, Image.FromFile(TrainImagePath), Image.FromFile(RotatedTrainImagePath))
        {
            pathHandler = MoveRight;
        }

        public new void LookForCheckpoints(Switch switch_1, Switch switch_2, Wagon wagon, Game game)
        {
            base.LookForCheckpoints(switch_1, switch_2, game);

            //Train split scenarios
            if (wagon.IsActive && wagon.X < switch_2.X && wagon.Y == 165 && pathHandler == MoveLeftNDown)
            {
                game.LooseGame();
            }
            else if (wagon.IsActive && X > switch_1.X && Y == 325 && wagon.pathHandler == MoveRightNUp)
            {
                game.LooseGame();
            }

            //Activate wagon scenar
            else if (X == 152 && Y == 165)
            {
                wagon.IsActive = true;
            }

            //Win game scenario
            else if (wagon.IsActive && X > 630 & X < 700 && Y == 165 && IsActive == false)
            {
                game.WinGame();
            }
        }
    }
}
