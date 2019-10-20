using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Interfaces
{
    public interface IAdvance
    {
        Position TurnAdvance(Position roverPosition, MarsOrientations roverOrientation);
    }
}
