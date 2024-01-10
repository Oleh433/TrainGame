using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainGame.TrainParts
{
    public class Wagon : MovingObjects
    {
        public const string WagonImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\Wagon.png";
        public const string RotatedWagonImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\RotatedWagon1.png";

        public Wagon(PictureBox pictureBox) : base(pictureBox, 90, 325, Image.FromFile(WagonImagePath), Image.FromFile(RotatedWagonImagePath))
        {
            pathHandler = MoveLeft;
        }

        public new void LookForCheckpoints(Switch switch_1, Switch switch_2, Train train, Game game)
        {
            base.LookForCheckpoints(switch_1, switch_2, game);

            //Train split scenarios
            if (X < switch_2.X && Y == switch_2.Y && train.pathHandler == train.MoveLeftNDown)
            {
                game.LooseGame();
            }
            else if (X > switch_1.X && Y == switch_1.Y && train.pathHandler == train.MoveRightNUp)
            {
                game.LooseGame();
            }
        }
    }
}
