using HepsiburadaCaseStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy
{
    /// <summary>
    /// This an receiver class
    /// </summary>
    public class Robot
    {
        private string[] directionArray = new string[4] { "N", "E", "S", "W" };
        private RobotCoordinate _coordinate;
        private Plateau _plateau;
        int _currentIndex;

        public Robot()
        {
           
        }

        public Robot(RobotCoordinate coordinate, Plateau plateau)
        {
            _coordinate = coordinate;
            _plateau = plateau;
            _currentIndex = Array.IndexOf(directionArray, coordinate.Direction);
        }

        public void TurnLeft()
        {
            _coordinate.Direction = rotateLeft();
        }

        public void TurnRight()
        {
            _coordinate.Direction = rotateRight();
            
        }

        //EX: Assume Max index reached to x coordinate, and the robot must to move east, then
        //it stops current location. Because the pletau is rectanguler
        public void MoveForward()
        {
            int x = _coordinate.X;
            int y = _coordinate.Y;
            int height = _plateau.Height;
            int width = _plateau.Width;

            switch (_coordinate.Direction.ToLower())
            {
                case "n":
                    if(y + 1 <= height)
                    {
                        y = y + 1;
                    }
                    break;
                case "s":
                    if((y - 1) >= 0)
                    {
                        y = y - 1;
                    }
                    break;

                case "e":
                    if(x + 1 <= width)
                    {
                        x = x + 1;
                    }
                    break;
                
                case "w":
                    if ((x - 1) >= 0)
                    {
                        x = x - 1;
                    }
                    break;
            }
            _coordinate.X = x;
            _coordinate.Y = y;
        }

        public string rotateLeft()
        {
            _currentIndex = (_currentIndex - 1) % 4 < 0 ? (_currentIndex - 1) + 4: (_currentIndex - 1);
            return directionArray[_currentIndex];
        }
        public string rotateRight()
        {
            _currentIndex = (_currentIndex + 1) % 4;
            return directionArray[_currentIndex];
        }
    }
}
