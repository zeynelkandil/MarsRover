using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class SouthDirectionState : RoverDirectionState
    {
        public SouthDirectionState(Point Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.SetY(Coordinates.Y - 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new EastDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new WestDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return RoverConstants.Directions.South;
        }
    }
}
