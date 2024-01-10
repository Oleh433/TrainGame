using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TrainGame.Switch;

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

        public PictureBox _pictureBox;
        public Graphics _graphics;

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

        public void DrawObject(Image im)
        {
            Graphics g = _pictureBox.CreateGraphics();

            g.DrawImage(im, X, Y);
        }

        public void HideDrawingBackground()
        {
            Graphics g = _pictureBox.CreateGraphics();

            using (Image im = Image.FromFile("C:\\Users\\Lenovo T470p\\source\\repos\\TrainGame\\TrainGame\\Railway\\roaddd1.png"))
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

        public void LookForCheckpoints(Switch switch_1, Switch switch_2, Game game)
        {
            //Switch 1 scenarois
            if (X == switch_1.X && Y == switch_1.Y)
            {
                if (switch_1.SwitchState == SwichStates.Left && pathHandler == MoveRight)
                {
                    pathHandler = MoveRightNUp;
                    CurrentObjectImage = RotatedObjectImage;
                }
                else if (switch_1.SwitchState == SwichStates.Left && pathHandler == MoveLeftNDown)
                {
                    pathHandler = MoveLeft;
                    CurrentObjectImage = ObjectImage;
                }

                //Derail scenarios
                else if (switch_1.SwitchState == SwichStates.Left && pathHandler == MoveLeft)
                {
                    game.LooseGame();
                }
                else if (switch_1.SwitchState == SwichStates.Right && pathHandler == MoveLeftNDown)
                {
                    game.LooseGame();
                }
            }

            //Switch 2 scenarois
            else if (X == switch_2.X && Y == switch_2.Y)
            {
                if (switch_2.SwitchState == SwichStates.Left && pathHandler == MoveRightNUp)
                {
                    pathHandler = MoveRight;
                    CurrentObjectImage = ObjectImage;
                }
                else if (switch_2.SwitchState == SwichStates.Left && pathHandler == MoveLeft)
                {
                    pathHandler = MoveLeftNDown;
                    CurrentObjectImage = RotatedObjectImage;
                }

                //Derail scenarios
                else if (switch_2.SwitchState == SwichStates.Right && pathHandler == MoveRightNUp)
                {
                    game.LooseGame();
                }
                else if (switch_2.SwitchState == SwichStates.Left && pathHandler == MoveRight)
                {
                    game.LooseGame();
                }
            }

            //Crash scenarios
            else if (X == 50 && Y == 165)
            {
                game.LooseGame();
            }
            else if (X == 650 && Y == 325)
            {
                game.LooseGame();
            }
            else if (X == 50 && Y == 325)
            {
                game.LooseGame();
            }
            else if (X == 760 && Y == 165)
            {
                game.LooseGame();
            }
        }
    }
}
