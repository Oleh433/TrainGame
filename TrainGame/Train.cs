using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame
{
    internal class Train
    {
        public int x = 40;
        public int y = 325;
        protected PictureBox _pictureBox;
        protected Graphics _graphics;

        public Train(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _graphics = pictureBox.CreateGraphics();
        }

        public void DrawBlack()
        {
            Graphics g = _pictureBox.CreateGraphics();

            g.DrawRectangle(new Pen(Color.Black), new Rectangle(x, y, 30, 20));
        }

        public void HideDrawingBackground()
        {
            Graphics g = _pictureBox.CreateGraphics();

            Color backgroundColor = Color.White;

            using (Image im = Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\roaddd.png"))
            {
                g.DrawImage(im,0,0);
            }
        }

        public void MoveRight(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            x += step;
        }

        public void MoveRightNUp(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            x += step;
            y -= step;
        }
    }
}
