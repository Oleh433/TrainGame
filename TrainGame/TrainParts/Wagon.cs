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
        public const string RotatedWagonImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\RotatedTrain.jpg";

        public Wagon(PictureBox pictureBox) : base(pictureBox, 100, 165, Image.FromFile(WagonImagePath), Image.FromFile(RotatedWagonImagePath))
        {
            pathHandler = MoveLeft;
        }


    }
}
