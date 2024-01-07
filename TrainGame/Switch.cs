using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TrainGame
{
    public class Switch
    {
        public string SwitchState = "left";

        public int X;
        public int Y;

        public Switch(int x, int y)
        {
            X = x; 
            Y = y;
        }
    }
}
