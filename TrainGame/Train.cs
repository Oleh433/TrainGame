using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace TrainGame
{
    public delegate void PathHandler(int step);

    internal class Train
    {
        public const string TrainImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\train.png";
        public const string RotatedTrainImagePath = "C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\RotatedTrain.jpg";

        public int x = 200;
        public int y = 325;
        public bool EngineState = false;
        public bool GameState = true;
        public Image TrainImage = Image.FromFile(TrainImagePath);





        public PathHandler pathHandler;

        protected PictureBox _pictureBox;
        protected Graphics _graphics;

        async public void SwitchEngineState(Switch switch_1, Switch switch_2)
        {
            if (EngineState == false)
            {
                EngineState = true;
                await Task.Run(() => PerformAnimation( switch_1, switch_2));
            }
            else
            {
                EngineState = false;
            }
        }

        public Train(PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
            _graphics = pictureBox.CreateGraphics();
            pathHandler = MoveRight;
        }

        public void ChangeMovingDirection()
        {
            if (pathHandler == MoveRight)
            {
                pathHandler = MoveLeft;
            }
            else if(pathHandler == MoveRightNUp)
            {
                pathHandler = MoveLeftNDown;
            }
            else if (pathHandler == MoveLeft)
            {
                pathHandler = MoveRight;
            }
            else
            {
                pathHandler = MoveRightNUp;
            }
        }

        public void DrawBlack()
        {
            Graphics g = _pictureBox.CreateGraphics();

            g.DrawImage(TrainImage, x, y);
        }

        public void HideDrawingBackground()
        {
            Graphics g = _pictureBox.CreateGraphics();

            using (Image im = Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\roaddd.png"))
            {
                g.DrawImage(im,0,0);
            }
        }

        public void Explode()
        {
            GameState = false;
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MoveRight(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            x += step;
        }

        public void MoveLeft(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            x -= step;
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

        public void MoveLeftNDown(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            x -= step;
            y += step;
        }

        private void PerformAnimation( Switch switch_1, Switch switch_2)
        {
            while (EngineState && GameState)
            {
                DrawBlack();
                pathHandler.Invoke(2);
                Thread.Sleep(50);
                HideDrawingBackground();

                LookForCheckpoints( switch_1, switch_2);
            }

            DrawBlack();
        }

        public Image RotateImage(Image originalImage, float angle)
        {
            // Створіть матрицю обертання
            Matrix matrix = new Matrix();
            matrix.RotateAt(angle, new Point(originalImage.Width / 2, originalImage.Height / 2));

            // Створіть об'єкт Bitmap для обернутої картинки
            Bitmap rotatedImage = new Bitmap(originalImage);

            // Застосуйте обертання до картинки
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.Transform = matrix;
                g.DrawImage(originalImage, new Point(x, y));
            }

            return rotatedImage;
        }

        private void LookForCheckpoints (Switch switch_1, Switch switch_2)
        {
            if (x == switch_1.X && y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveRight)
            {
                pathHandler = MoveRightNUp;
                TrainImage = RotateImage(TrainImage, 45);
            }

            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveRightNUp)
            {
                pathHandler = MoveRight;
            }
            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveRightNUp)
            {
                Explode();
            }
            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveRight)
            {
                pathHandler = MoveRight;
            }
            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveRight)
            {
                Explode();
            }


            else if (x == switch_1.X && y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveLeft)
            {
                Explode();
            }
            else if (x == switch_1.X && y == switch_1.Y && switch_1.SwitchState == "right"  && pathHandler == MoveLeftNDown)
            {
                Explode();
            }
            else if (x == switch_1.X && y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveLeftNDown)
            {
                pathHandler = MoveLeft;
            }

            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveLeft)
            {
                pathHandler = MoveLeftNDown;
            }
            else if (x == switch_2.X && y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveLeft)
            {
                pathHandler = MoveLeft;
            }
        }
    }
}
