using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame.TrainParts
{
    public delegate void PathHandler(int step);

    public class MovingObjects
    {
        public Image CurrentObjectImage;
        public Image ObjectImage;
        public Image RotatedObjectImage;

        public int X;
        public int Y;

        public bool IsActive;

        public PathHandler? pathHandler;

        protected PictureBox _pictureBox;
        protected Graphics _graphics;

        public MovingObjects(PictureBox pictureBox, int x, int y, Image objectImage, Image rotatedObjectImage)
        {
            _pictureBox = pictureBox;
            _graphics = pictureBox.CreateGraphics();

            X = x;
            Y = y;

            CurrentObjectImage = objectImage;
            ObjectImage = objectImage;
            RotatedObjectImage = rotatedObjectImage;
        }

        public void ChangeMovingDirection()
        {
            if (pathHandler == MoveRight)
            {
                pathHandler = MoveLeft;
            }
            else if (pathHandler == MoveRightNUp)
            {
                pathHandler = MoveLeftNDown;
            }
            else if (pathHandler == MoveLeft)
            {
                pathHandler = MoveRight;
            }
            else if(pathHandler == MoveLeftNDown)
            {
                pathHandler = MoveRightNUp;
            }
        }

        public void DrawBlack(Image im)
        {
            Graphics g = _pictureBox.CreateGraphics();

            g.DrawImage(im, X, Y);
        }

        public void HideDrawingBackground()
        {
            Graphics g = _pictureBox.CreateGraphics();

            using (Image im = Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\roaddd.png"))
            {
                g.DrawImage(im, 0, 0);
            }
        }
        
        public void MoveRight(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            X += step;
        }

        public void MoveLeft(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            X -= step;
        }

        public void MoveRightNUp(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            X += step;
            Y -= step;
        }

        public void MoveLeftNDown(int step)
        {
            if (step < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            X -= step;
            Y += step;
        }

        

        public void LookForCheckpoints(Switch switch_1, Switch switch_2, Wagon wagon , Game game)
        {
            if (X == switch_1.X && Y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveRight)
            {
                pathHandler = MoveRightNUp;
                CurrentObjectImage = RotatedObjectImage;
            }

            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveRightNUp)
            {
                pathHandler = MoveRight;
                CurrentObjectImage = ObjectImage;
            }
            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveRightNUp)
            {
                game.EndGame();
            }
            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveRight)
            {
                pathHandler = MoveRight;
            }
            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveRight)
            {
                game.EndGame();
            }


            else if (X == switch_1.X && Y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveLeft)
            {
                game.EndGame();
            }
            else if (X == switch_1.X && Y == switch_1.Y && switch_1.SwitchState == "right" && pathHandler == MoveLeftNDown)
            {
                game.EndGame();
            }
            else if (X == switch_1.X && Y == switch_1.Y && switch_1.SwitchState == "left" && pathHandler == MoveLeftNDown)
            {
                pathHandler = MoveLeft;
                CurrentObjectImage = ObjectImage;
            }

            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "left" && pathHandler == MoveLeft)
            {
                pathHandler = MoveLeftNDown;
                CurrentObjectImage = RotatedObjectImage;
            }
            else if (X == switch_2.X && Y == switch_2.Y && switch_2.SwitchState == "right" && pathHandler == MoveLeft)
            {
                pathHandler = MoveLeft;
            }
            else if (X == 120 && Y == 165)
            {

                if (!wagon.IsActive)
                {
                    wagon.IsActive = true;
                    wagon.pathHandler = MoveLeft;
                }
            }
        }
    }
}
