using RoverMars.Mars.Domain;
using RoverMars.Rover.Domain;
using RoverMars.Rover.Domain.Algorithms;
using System;

namespace RoverMars
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepSendRoverToMars = false;
            do
            {
                Console.WriteLine("Enter The Size of the Mars Square: ");

                /*
                 Create the square in Mars
                 */
                Console.WriteLine("Enter the X:");
                var squareX = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Y:");
                var squareY = Convert.ToInt32(Console.ReadLine());
                var squareSize = new MarsSquareSize(squareX, squareY);

                /*
                Create the orientation default
                */
                Console.WriteLine("Enter the start Rover Orientation (N,S,W,E)");
                var roverParameterOrientation = Console.ReadLine();
                var roverParameterOrientationIsValid = ValidateProgram.validateKeyOrientation(roverParameterOrientation);
                while (string.IsNullOrEmpty(roverParameterOrientation) || !roverParameterOrientationIsValid)
                {
                    Console.WriteLine("The orientation can't be empty and a value permite: ");
                    Console.WriteLine("Enter the start Rover Orientation (N,S,W,E)");
                    roverParameterOrientation = Console.ReadLine();
                    roverParameterOrientationIsValid = ValidateProgram.validateKeyOrientation(roverParameterOrientation);
                }

                Enum.TryParse(roverParameterOrientation, out MarsOrientations rovertOrientation);

                /*
                 Create the commands
                */
                Console.WriteLine("Enter the Commands");
                var commands = Console.ReadLine();

                /*
                 Create The Rover Vechicle with his algorithms
                 */
                var roverVechicle = new RoverSpaceVehicle(new TurnLeftInMars(), new TurnRightInMars(), new AdvanceInMars(), rovertOrientation);

                /*
                 Create the Square in Mars with his Rover Vechicle
                 */
                var square = new MarsSquare(squareSize, roverVechicle);

                square.ExcecuteCommand(commands);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("************* Rover Report: **************");
                Console.WriteLine(square.ToString());
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("************* Rover playing in Mars! **************");
                Console.WriteLine("***************************************************");
                Console.WriteLine("***************************************************");
                Console.WriteLine("**********************[*]************************");
                Console.WriteLine("¿Do you want play again? (Y/N)");
                Console.WriteLine("**********************[*]************************");
                Console.WriteLine("");
                Console.WriteLine("");
                keepSendRoverToMars = (Console.ReadLine() == "Y") ? true : false;

            } while (keepSendRoverToMars);

        }
    }

    public static class ValidateProgram
    {
        public static bool validateKeyOrientation(string keyOrientation)
        {
            switch (keyOrientation)
            {
                case "N":
                case "E":
                case "W":
                case "S":
                    return true;
                default:
                    return false;
            }
        }
    }
}

