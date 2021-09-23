using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12RainRisk
{
    class Direction2
    {
        public int calc(List<string> Instructions)
        {
            //initializes the objs and variables needed
            DirectionModel2 direction = new DirectionModel2();
            string val;

            foreach (var item in Instructions)
            {
                switch (item[0])
                {
                    case ('N'):
                        val = item.Remove(0, 1);
                        direction.WPnorth += int.Parse(val);
                        break;

                    case ('S'):
                        val = item.Remove(0, 1);
                        direction.WPsouth += int.Parse(val);
                        break;

                    case ('E'):
                        val = item.Remove(0, 1);
                        direction.WPeast += int.Parse(val);
                        break;

                    case ('W'):
                        val = item.Remove(0, 1);
                        direction.WPwest += int.Parse(val);
                        break;

                    case ('L'):
                        val = item.Remove(0, 1);
                        if(val == "90")
                        {
                            direction.directionDegrees = -(90);
                        }
                        else if(val == "180")
                        {
                            for(int i = 0; i <= 1; i++)
                            {
                                direction.directionDegrees = -(90);
                            }
                        }
                        else if (val == "270")
                        {
                            for (int i = 0; i <= 2; i++)
                            {
                                direction.directionDegrees = -(90);
                            }
                        }
                        else if (val == "360")
                        {
                            for (int i = 0; i <= 3; i++)
                            {
                                direction.directionDegrees = -(90);
                            }
                        }
                        break;

                    case ('R'):
                        val = item.Remove(0, 1);
                        if (val == "90")
                        {
                            direction.directionDegrees = 90;
                        }
                        else if (val == "180")
                        {
                            for (int i = 0; i <= 1; i++)
                            {
                                direction.directionDegrees = 90;
                            }
                        }
                        else if (val == "270")
                        {
                            for (int i = 0; i <= 2; i++)
                            {
                                direction.directionDegrees = 90;
                            }
                        }
                        else if (val == "360")
                        {
                            for (int i = 0; i <= 3; i++)
                            {
                                direction.directionDegrees = 90;
                            }
                        }
                        break;
                    case ('F'):                      
                        val = item.Remove(0, 1);
                        for (int i = 0; i < int.Parse(val) ; i++)
                        {
                            direction.north += direction.WPnorth;
                            direction.east += direction.WPeast;
                            direction.south += direction.WPsouth;
                            direction.west += direction.WPwest;
                        }
                        break;
                }
            }

            int distance = Math.Abs(direction.east - direction.west) + Math.Abs(direction.north - direction.south);

            return distance;
        }

        public void multiplier( int inc)
        {

        }
    }
}
