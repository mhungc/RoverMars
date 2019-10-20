using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Mars.Domain
{
    public struct MarsSquareSize
    {
        private int _X;
        private int _Y;
        public int X { get { return _X; } }

        public int Y { get { return _Y; } }

        public MarsSquareSize(int _x, int _y)
        {
            this._X = _x;
            this._Y = _y;
        }
    }
}
