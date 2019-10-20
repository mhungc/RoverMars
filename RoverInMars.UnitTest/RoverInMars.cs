using RoverMars.Rover.Domain;
using RoverMars.Rover.Domain.Algorithms;
using RoverMars.Rover.Domain.Interfaces;
using System;
using Xunit;

namespace RoverInMars.UnitTest
{
    public class RoverInMars
    {
        private ITurnLeft _turnLeftAlgorithm;
        private ITurnRight _turnRightAlgorithm;
        private IAdvance _advanceAlgorithm;

        public RoverInMars()
        {
            _turnLeftAlgorithm = new TurnLeftInMars();
            _turnRightAlgorithm = new TurnRightInMars();
            _advanceAlgorithm = new AdvanceInMars();
        }

        [Theory]
        [InlineData(MarsOrientations.N, MarsOrientations.W)]
        [InlineData(MarsOrientations.W, MarsOrientations.S)]
        [InlineData(MarsOrientations.S, MarsOrientations.E)]
        [InlineData(MarsOrientations.E, MarsOrientations.N)]
        public void RoverTurnLeft_ShouldReturnTheCorrespondentOrientationDependingHisActualOrientation(MarsOrientations roverActualOrientation, MarsOrientations roverFinalOrientation)
        {
            var stub = new RoverSpaceVehicle(
                _turnLeftAlgorithm
                , _turnRightAlgorithm
                , _advanceAlgorithm
                , roverActualOrientation);

            stub.PerformTurnLeft();

            Assert.Equal(roverFinalOrientation, stub._roverOrientationsInMars);
        }

        [Theory]
        [InlineData(MarsOrientations.N, MarsOrientations.E)]
        [InlineData(MarsOrientations.E, MarsOrientations.S)]
        [InlineData(MarsOrientations.S, MarsOrientations.W)]
        [InlineData(MarsOrientations.W, MarsOrientations.N)]
        public void RoverTurnRight_ShouldReturnTheCorrespondentOrientationDependingHisActualOrientation(MarsOrientations roverActualOrientation, MarsOrientations roverFinalOrientation)
        {
            var stub = new RoverSpaceVehicle(
               _turnLeftAlgorithm
                , _turnRightAlgorithm
                , _advanceAlgorithm
                , roverActualOrientation);

            stub.PerfomTurnRight();

            Assert.Equal(roverFinalOrientation, stub._roverOrientationsInMars);
        }

    }
}
