using RoverMars.Rover.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Algorithms
{
    public class AdvanceInMars : IAdvance
    {
        //private Position _roverPosition;
        //private MarsOrientations _roverOrientation;

        //public AdvanceInMars(Position roverPosition, MarsOrientations roverOrientation)
        //{
        //    _roverPosition = roverPosition;
        //    _roverOrientation = roverOrientation;
        //}

        public Position TurnAdvance(Position roverPosition, MarsOrientations roverOrientation)
        {
            if (roverOrientation == MarsOrientations.N)
            {
                return new Position(roverPosition.X, roverPosition.Y + 1);
            }
            else if (roverOrientation == MarsOrientations.E)
            {
                return new Position(roverPosition.X + 1, roverPosition.Y);
            }
            else if (roverOrientation == MarsOrientations.S)
            {
                return new Position(roverPosition.X, roverPosition.Y - 1);
            }
            else if (roverOrientation == MarsOrientations.W)
            {
                return new Position(roverPosition.X - 1, roverPosition.Y);
            }
            else
            {
                return roverPosition;
            }
        }
    }
}
