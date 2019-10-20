﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position()
        {
            X = 0;
            Y = 0;
        }
    }
}
