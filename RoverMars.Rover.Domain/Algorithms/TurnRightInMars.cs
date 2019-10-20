using RoverMars.Rover.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Algorithms
{
    public class TurnRightInMars : ITurnRight
    {
        public MarsOrientations TurnRight(MarsOrientations roverOrientation)
        {
            return (roverOrientation + 1) > MarsOrientations.W ? MarsOrientations.N : roverOrientation + 1;
        }
    }
}
