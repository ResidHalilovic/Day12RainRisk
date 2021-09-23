using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12RainRisk
{
    class DirectionModel
    {
        // will hold the direction of all directions 
        public int north { get; set; }
        public int east { get; set; } 
        public int south { get; set; }
        public int west { get; set; }

        //from 0 to 360 - 0 east - 360 also east 
        //changes apon movement left or right
        private int _directionDegrees;
        public int directionDegrees {
            get { return _directionDegrees; }
            set {
                //Incase degrees exceed 360 or goes lower than 0
                if (_directionDegrees+value > 360)
                {
                    _directionDegrees += (value - 360);
                }
                else if (_directionDegrees + value < 0)
                {
                    _directionDegrees += (value + 360);
                }
                else if(_directionDegrees + value == 360)
                {
                    _directionDegrees = 0;
                }
                else
                {
                    _directionDegrees += value;
                }

                //used to set Direction
                if (0 <= _directionDegrees && _directionDegrees <= 89)
                {
                    Direction = "East";
                }
                else if(90 <= _directionDegrees && _directionDegrees <= 179)
                {
                    Direction = "South";
                }
                else if (180 <= _directionDegrees && _directionDegrees <= 269)
                {
                    Direction = "West";
                }
                else if (270 <= _directionDegrees && _directionDegrees <= 359)
                {
                    Direction = "North";
                }
                
            } 
        }
        public string Direction { get; set; } = "East";
    }
}
