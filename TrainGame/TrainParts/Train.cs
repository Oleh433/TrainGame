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
    }
}
