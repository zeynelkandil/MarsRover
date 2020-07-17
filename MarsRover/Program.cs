using System;
using System.Linq;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the plateau limits");
            var plateauLimits = Console.ReadLine();
            var limits = plateauLimits.Split(" ");
            if (limits.Length == 2)
            {
                var xLimit = Convert.ToInt32(limits[0]);
                var yLimit = Convert.ToInt32(limits[0]);
                Plateau plateau = new Plateau(xLimit, yLimit);

                Console.WriteLine("Locate Rover on the plateau");
                var positionAndDirection = Console.ReadLine();
                var pieces = positionAndDirection.Split(" ");

                if (pieces.Length == 3)
                {
                    plateau.LocateRover(new Rover(new Point(Convert.ToInt32(pieces[0]), Convert.ToInt32(pieces[1])), pieces[2]));

                    Console.WriteLine("Move the rover");
                    var commands = Console.ReadLine();

                    commands.ToList().ForEach(x => plateau.MoveRover(x.ToString()));

                    Console.WriteLine(plateau.Rover);
                }
            }

            Console.ReadKey();
        }
    }
}
