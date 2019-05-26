using HepsiburadaCaseStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Commands
{
    class LeftRotationCommand : ICommand
    {
        private IRobot _robot;

        public LeftRotationCommand(IRobot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.TurnLeft();       
        }
    }
}
