using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public abstract class RoverDirectionState
    {
        public Point Coordinates { get; private set; }
        public RoverDirectionState(Point Coordinates)
        {
            this.Coordinates = Coordinates;
        }
        public abstract void MoveForward();
        public abstract RoverDirectionState TurnLeft();
        public abstract RoverDirectionState TurnRight();
    }
}
