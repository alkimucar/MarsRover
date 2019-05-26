using HepsiburadaCaseStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Commands
{
    class RightRotationCommand : ICommand
    {
        private IRobot _robot;

        public RightRotationCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.TurnRight();   
        }
    }
}
