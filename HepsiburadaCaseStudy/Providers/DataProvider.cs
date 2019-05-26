using HepsiburadaCaseStudy.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace HepsiburadaCaseStudy.Service
{
    public class DataProvider
    {
        string filePath = @"../../Data/MarsRoverAssignment.txt";
        List<RobotCoordinate> coordinates = new List<RobotCoordinate>();
        List<string> directions = new List<string>();
        Plateau plateau = new Plateau();
        
        public Plateau getPlateuSize()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {       
                        string[] maxSize = line.Trim().Split(null);
                        if (maxSize != null && maxSize.Length == 2)
                        {   
                            plateau.Width = Convert.ToInt32(maxSize[0]);
                            plateau.Height = Convert.ToInt32(maxSize[1]);
                        }
                        else
                        {
                            Console.WriteLine("Input Error - getPlateuSize() - While reading maximum width and height value from file");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        break; 
                    }
                    file.Close();
                }
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            return plateau;
        }

        public List<RobotCoordinate> getRobotCoordinates()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    int counter = 0;
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        RobotCoordinate coordinate = new RobotCoordinate(0, 0, "N");
                        
                        if (counter % 2 == 1)
                        {
                            string[] initialLocation = line.Trim().Split(null);

                            if (initialLocation != null && initialLocation.Length == 3)
                            {
                                coordinate.X = Convert.ToInt32(initialLocation[0]);
                                coordinate.Y = Convert.ToInt32(initialLocation[1]);
                                coordinate.Direction = initialLocation[2];
                                coordinates.Add(coordinate);
                            }
                            else
                            {
                                Console.WriteLine("Input Error - getRobotCoordinates() - While reading initial location value from file");
                                Console.ReadLine();
                                Environment.Exit(0);
                            } 
                        }
                        counter++;
                    }
                    file.Close();
                }
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            return coordinates;
        }

        public List<string> getDirections()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    int counter = 0;
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        if (counter % 2 == 0 && counter != 0)
                        {
                            foreach (char chr in line.Trim().ToLower().ToCharArray())
                            {
                                if (!(chr.Equals('l') || chr.Equals('r') || chr.Equals('m')))
                                {
                                    Console.WriteLine("Input Error - getDirection() - While reading directions values from file");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                }
                            }
                            directions.Add(line.Trim());
                        }
                        
                        counter++;
                    }
                    file.Close();
                }
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
            return directions;
        }
    }
}