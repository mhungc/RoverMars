using RoverMars.Mars.Domain.Interfaces;
using RoverMars.Rover.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverMars.Mars.Domain
{
    public class MarsSquare : ICommand
    {
        private MarsSquareSize _squareSize;
        public MarsSquareSize SquareSize => _squareSize;

        private RoverSpaceVehicle _roverSpaceVehicle;

        public MarsSquare(MarsSquareSize squareSize, RoverSpaceVehicle roverVehicle)
        {
            _squareSize = squareSize;
            _roverSpaceVehicle = roverVehicle;
        }

        public void ExcecuteCommand(string commands)
        {
            foreach (var command in commands)
            {
                _roverSpaceVehicle.ProcessCommand(command);
            };
        }

        public bool IsRobotInsideBoundaries
        {
            get
            {
                bool isInsideBoundaries = false;

                if (_roverSpaceVehicle._roverPositionInMars.X < 0 || _roverSpaceVehicle._roverPositionInMars.Y < 0)
                    return isInsideBoundaries;

                if (_roverSpaceVehicle._roverPositionInMars.X <= _squareSize.X && _roverSpaceVehicle._roverPositionInMars.Y <= _squareSize.Y)
                    isInsideBoundaries = true;

                return isInsideBoundaries;
            }
        }

        public override string ToString()
        {
            var printedRoverInformation = string.Format("{0}, {1}, ({2}, {3})",
               IsRobotInsideBoundaries,
               _roverSpaceVehicle._roverOrientationsInMars.ToString(),
               _roverSpaceVehicle._roverPositionInMars.X,
               _roverSpaceVehicle._roverPositionInMars.Y);

            return printedRoverInformation;
        }

    }
}
