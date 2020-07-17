using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        private RoverDirectionState RoverState;

        public Rover(Point coordinates, string direction)
        {
            this.RoverState = DirectionStateFactory.Create(coordinates, direction);
        }

        public void MoveForward()
        {
            this.RoverState.MoveForward();
        }

        public void TurnLeft()
        {
            this.RoverState = this.RoverState.TurnLeft();
        }

        public void TurnRight()
        {
            this.RoverState = this.RoverState.TurnRight();
        }

        public Point GetCoordinates()
        {
            return this.RoverState.Coordinates;
        }

        public override string ToString()
        {
            return this.GetCoordinates() + " " + this.RoverState;
        }
    }
}
