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

        public Train(PictureBox pictureBox, int x, int y) : base(pictureBox, x, y, Image.FromFile(TrainImagePath), Image.FromFile(RotatedTrainImagePath))
        {
            pathHandler = MoveRight;
        }

        public void LookForCheckpoints(Switch switch_1, Switch switch_2, Wagon wagon, Game game)
        {
            base.LookForCheckpoints(switch_1, switch_2, game);

            //Win game scenario
            if (wagon.IsActive && Y == 165 && X > 620 && X < 700 && IsActive == false)
            {
                game.WinGame();
            }

            //Train split scenarios
            else if(wagon.IsActive && X < switch_2.X && Y == switch_2.Y && wagon.pathHandler == wagon.MoveLeftNDown)
            {
                game.LoseGame();
            }
            else if (wagon.IsActive && X > switch_1.X && Y == switch_1.Y && wagon.pathHandler == wagon.MoveRightNUp)
            {
                game.LoseGame();
            }

            //Activate wagon scenario
            else if (X == wagon.X + 52 && Y == wagon.Y)
            {
                wagon.IsActive = true;
            }
        }
    }
}
