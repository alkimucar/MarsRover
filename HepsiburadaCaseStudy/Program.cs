using HepsiburadaCaseStudy.Commands;
using HepsiburadaCaseStudy.Interfaces;
using HepsiburadaCaseStudy.Models;
using HepsiburadaCaseStudy.Service;
using System;
using System.Linq;


namespace HepsiburadaCaseStudy
{
    class Program
    {  
        static void Main(string[] args)
        {
            DataProvider dataProvider = new DataProvider();
            Plateau plateau = dataProvider.getPlateuSize();
            var robotsCoordinates = dataProvider.getRobotCoordinates();
            var robotDirections = dataProvider.getDirections();

            if(robotsCoordinates.Count != robotDirections.Count)
            {
                Console.WriteLine("Error - One of them is missing - robotsCoordinates or robotDirections ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            

            for(int i = 0; i < robotsCoordinates.Count; i++)
            {
                var robotCoordinate = robotsCoordinates.ElementAt(i);

                IRobot robot = new Robot(robotCoordinate, plateau);
                RemoteControl rc = new RemoteControl();

                for(int j = 0; j < robotDirections.ElementAt(i).ToCharArray().Length; j++)
                {
                    var direction = robotDirections.ElementAt(i);
                    if (direction.ToLower().ToCharArray()[j] == 'l')
                    {
                        ICommand rotateLeft = new LeftRotationCommand(robot);
                        rc.SendRequest(rotateLeft);
                    }
                    else if (direction.ToLower().ToCharArray()[j] == 'r')
                    {
                        ICommand rotateRight = new RightRotationCommand(robot);
                        rc.SendRequest(rotateRight);

                    }
                    else if (direction.ToLower().ToCharArray()[j] == 'm')
                    {
                        ICommand moveForward = new MoveCommand(robot);
                        rc.SendRequest(moveForward);
                    }
                    else
                    {
                        //I have already checked in DataProvider class.
                    }
                    //You can see each movements of robots
                    //Console.WriteLine("coordinates => X: " + robotCoordinate.X + " Y: " + robotCoordinate.Y + " Direction: " + robotCoordinate.Direction);
                }
                Console.WriteLine(robotCoordinate.X + " " + robotCoordinate.Y + " " + robotCoordinate.Direction);
            }
            Console.ReadLine();
        }
    }
}
