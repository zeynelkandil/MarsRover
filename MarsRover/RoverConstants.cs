using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public sealed class RoverConstants
    {
        public sealed class Directions
        {
            public const string North = "N";
            public const string South = "S";
            public const string East = "E";
            public const string West = "W";
        }

        public sealed class Commands
        {
            public const string MoveForward = "M";
            public const string TurnLeft = "L";
            public const string TurnRight = "R";
        }
    }
}
