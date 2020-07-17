using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class NorthDirectionState : RoverDirectionState
    {
        public NorthDirectionState(Point Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.SetY(Coordinates.Y + 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new WestDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new EastDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return RoverConstants.Directions.North;
        }
    }
}
