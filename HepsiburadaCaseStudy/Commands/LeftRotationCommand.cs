using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Commands
{
    class LeftRotationCommand : ICommand
    {
        private Robot _robot;

        public LeftRotationCommand(Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.TurnLeft();       
        }
    }
}
