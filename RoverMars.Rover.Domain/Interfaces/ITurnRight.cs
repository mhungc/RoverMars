﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Interfaces
{
    public interface ITurnRight
    {
        MarsOrientations TurnRight(MarsOrientations roverOrientation);
    }
}
