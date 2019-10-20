using RoverMars.Rover.Domain.Abstract;
using RoverMars.Rover.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Rover.Domain
{
    public class RoverSpaceVehicle : SpaceVehicleEngine
    {
        public RoverSpaceVehicle(
                   ITurnLeft turnLeftAlgorithm
                    , ITurnRight turnRightAlgorithm
                    , IAdvance advanceAlgorithm
                    , MarsOrientations roverOrientation)
        {
            _turnLeftBehavior = turnLeftAlgorithm;
            _turnRightBehavior = turnRightAlgorithm;
            _advanceBehavior = advanceAlgorithm;
            _roverPositionInMars = new Position(); //Default 0 , 0 Coordination;
            _roverOrientationsInMars = roverOrientation;
        }

        public override void ProcessCommand(char command)
        {
            throw new NotImplementedException();
        }
    }
}
