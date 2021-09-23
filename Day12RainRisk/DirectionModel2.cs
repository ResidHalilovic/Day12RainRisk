using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12RainRisk
{
    class DirectionModel2
    {
        // sets starting pos of ship
        public int north { get; set; } 
        public int east { get; set; } 
        public int south { get; set; }
        public int west { get; set; }

        // sets starting waypoints of ship
        public int WPnorth { get; set; } = 1;
        public int WPeast { get; set; } = 10;
        public int WPsouth { get; set; }
        public int WPwest { get; set; }


        //from 0 to 360 - 0 east - 360 also east 
        //changes apon movement left or right
        private int _directionDegrees;
        public int directionDegrees
        {
            get { return _directionDegrees; }
            set
            {
                //Incase degrees exceed 360 or goes lower than 0
                if (_directionDegrees + value > 360)
                {
                    _directionDegrees += (value - 360);
                }
                else if (_directionDegrees + value < 0)
                {
                    _directionDegrees += (value + 360);
                }
                else if (_directionDegrees + value == 360)
                {
                    _directionDegrees = 0;
                }
                else
                {
                    _directionDegrees += value;
                }

                //used to set Direction               
                int n = WPnorth;
                int s = WPsouth;
                int e = WPeast;
                int w = WPwest;
                if (0 <= _directionDegrees && _directionDegrees <= 89)
                {
                    if(Direction != "East")
                    {                       
                        if(Direction == "North")
                        {
                            WPeast = n;
                            WPsouth = e;
                            WPwest = s;
                            WPnorth = w;
                        }
                        else if(Direction == "South")
                        {
                            WPeast = s;
                            WPsouth = w;
                            WPwest = n;
                            WPnorth = e;
                        }
                    }
                    Direction = "East";
                }
                else if (90 <= _directionDegrees && _directionDegrees <= 179)
                {
                    if (Direction != "South")
                    {
                        if (Direction == "East")
                        {
                            WPeast = n;
                            WPsouth = e;
                            WPwest = s;
                            WPnorth = w;
                        }
                        else if (Direction == "West")
                        {
                            WPeast = s;
                            WPsouth = w;
                            WPwest = n;
                            WPnorth = e;
                        }
                    }
                    Direction = "South";
                }
                else if (180 <= _directionDegrees && _directionDegrees <= 269)
                {
                    if (Direction != "West")
                    {
                        if (Direction == "North")
                        {
                            WPeast = s;
                            WPsouth = w;
                            WPwest = n;
                            WPnorth = e;
                        }
                        else if (Direction == "South")
                        {
                            WPeast = n;
                            WPsouth = e;
                            WPwest = s;
                            WPnorth = w;
                        }
                    }
                    Direction = "West";
                }
                else if (270 <= _directionDegrees && _directionDegrees <= 359)
                {
                    if (Direction != "North")
                    {
                        if (Direction == "East")
                        {
                            WPeast = s;
                            WPsouth = w;
                            WPwest = n;
                            WPnorth = e;
                        }
                        else if (Direction == "West")
                        {
                            WPeast = n;
                            WPsouth = e;
                            WPwest = s;
                            WPnorth = w;
                        }
                    }
                    Direction = "North";
                }

            }
        }
        public string Direction { get; set; } = "East";
    }
}
