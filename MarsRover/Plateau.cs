using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Plateau
    {
        private int xLimit { get; set; }
        private int yLimit { get; set; }
        public Rover Rover { get; private set; }
        public Plateau(int xLimit, int yLimit)
        {
            this.xLimit = xLimit;
            this.yLimit = yLimit;
        }

        public void LocateRover(Rover rover)
        {
            if (rover.GetCoordinates().X > this.xLimit)
                throw new ArgumentOutOfRangeException();
            if (rover.GetCoordinates().Y > this.yLimit)
                throw new ArgumentOutOfRangeException();

            this.Rover = rover;
        }

        public void MoveRover(string command)
        {
            switch (command)
            {
                case RoverConstants.Commands.MoveForward:
                    if ((Rover.GetCoordinates().X <= this.xLimit && Rover.GetCoordinates().Y <= this.yLimit))
                        Rover.MoveForward();
                    break;
                case RoverConstants.Commands.TurnLeft:
                    Rover.TurnLeft();
                    break;
                case RoverConstants.Commands.TurnRight:
                    Rover.TurnRight();
                    break;
            }
        }
    }
}
