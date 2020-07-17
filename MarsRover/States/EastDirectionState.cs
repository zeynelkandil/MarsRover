using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace MarsRover
{
    public class EastDirectionState : RoverDirectionState
    {
        public EastDirectionState(Point Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.SetX(Coordinates.X + 1);
        }

        public override RoverDirectionState TurnLeft()
        {
            return new NorthDirectionState(Coordinates);
        }

        public override RoverDirectionState TurnRight()
        {
            return new SouthDirectionState(Coordinates);
        }

        public override string ToString()
        {
            return RoverConstants.Directions.East;
        }
    }
}
