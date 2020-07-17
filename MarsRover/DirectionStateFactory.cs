using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class DirectionStateFactory
    {
        public static RoverDirectionState Create(Point coordinates, string direction)
        {
            var x = coordinates.X;
            var y = coordinates.Y;
            switch (direction)
            {
                case RoverConstants.Directions.North:
                    return new NorthDirectionState(new Point(x, y));
                case RoverConstants.Directions.South:
                    return new SouthDirectionState(new Point(x, y));
                case RoverConstants.Directions.East:
                    return new EastDirectionState (new Point(x, y));
                case RoverConstants.Directions.West:
                    return new WestDirectionState(new Point(x, y));
                default:
                    return new EastDirectionState(new Point(x, y));
            }
        }
    }
}
