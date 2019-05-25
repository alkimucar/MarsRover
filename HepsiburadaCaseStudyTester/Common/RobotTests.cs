using Microsoft.VisualStudio.TestTools.UnitTesting;
using HepsiburadaCaseStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Tests
{
    [TestClass()]
    public class RobotRoverTests
    {
        [TestMethod()]
        public void rotateLeftTest()
        {
            Robot robot = new Robot();
            Assert.AreSame("W", robot.rotateLeft());

        }

        [TestMethod()]
        public void rotateRightTest()
        {
            Robot robot = new Robot();
            Assert.AreSame("E", robot.rotateRight());
        }
    }
}