using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class WestDirectionState : RoverDirectionState
    {
        public WestDirectionState(Point Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.SetX(Coordinates.X - 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new SouthDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new NorthDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return RoverConstants.Directions.West;
        }
    }
}
