using RoverMars.Rover.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Algorithms
{
    public class TurnLeftInMars : ITurnLeft
    {
        public MarsOrientations TurnLeft(MarsOrientations roverOrientation)
        {
            return (roverOrientation - 1) < MarsOrientations.N ? MarsOrientations.W : roverOrientation - 1;
        }
    }

}
