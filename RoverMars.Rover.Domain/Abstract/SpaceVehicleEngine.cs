using RoverMars.Rover.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain.Abstract
{
    public abstract class SpaceVehicleEngine
    {
        public ITurnLeft _turnLeftBehavior;
        public ITurnRight _turnRightBehavior;
        public IAdvance _advanceBehavior;
        public MarsOrientations _roverOrientationsInMars;
        public Position _roverPositionInMars;

        public void PerformTurnLeft()
        {
            _roverOrientationsInMars = _turnLeftBehavior.TurnLeft(_roverOrientationsInMars);
        }

        public void PerfomTurnRight()
        {

            _roverOrientationsInMars = _turnRightBehavior.TurnRight(_roverOrientationsInMars);
        }

        public void PerformAdvance()
        {
            _roverPositionInMars = _advanceBehavior.TurnAdvance(_roverPositionInMars, _roverOrientationsInMars);
        }

        public abstract void ProcessCommand(char command);
    }
}
