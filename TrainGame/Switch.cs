﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainGame.TrainParts;

namespace TrainGame
{
    public class Switch
    {
        public SwichStates SwitchState = SwichStates.Right;

        public int X;
        public int Y;

        public Image SwitchRight;
        public Image SwitchLeft;

        public enum SwichStates
        {
            Left,
            Right
        }

        public Switch(int x, int y, Image sR, Image sL)
        {
            X = x; 
            Y = y;
            SwitchRight = sR;
            SwitchLeft = sL;
        }

        public void DrawObject(PictureBox _pictureBox, int x, int y)
        {
            Graphics g = _pictureBox.CreateGraphics();

            if (SwitchState == SwichStates.Left)
            {
                g.DrawImage(SwitchLeft, x, y);
            }
            else
            {
                g.DrawImage(SwitchRight, x, y);
            }
        }
    }
}
