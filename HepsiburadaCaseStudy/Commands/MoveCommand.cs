using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Commands
{
    class MoveCommand :ICommand
    {
        private Robot _robot;

        public MoveCommand(Robot robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.MoveForward();
        }
    }
}
