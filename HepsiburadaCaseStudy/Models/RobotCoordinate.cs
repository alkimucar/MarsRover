using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy.Models
{
    public class RobotCoordinate
    {
        private int _x;
        private int _y;
        private string _direction;
    
        public RobotCoordinate(int x, int y, string direction)
        {
            _x = x;
            _y = y;
            _direction = direction;
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }

        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
      
    }
}
