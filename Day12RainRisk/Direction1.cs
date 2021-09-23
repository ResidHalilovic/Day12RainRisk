using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12RainRisk
{
    class Direction1
    {
        
        public int calc(List<string> Instructions)
        {
            //initializes the objs and variables needed
            DirectionModel direction = new DirectionModel();
            string val;

            foreach(var item in Instructions)
            {
                switch(item[0])
                {
                    case ('N'):
                        val = item.Remove(0, 1);
                        direction.north += int.Parse(val);
                        break;

                    case ('S'):
                        val = item.Remove(0, 1);
                        direction.south += int.Parse(val);
                        break;
    
                    case ('E'):
                        val = item.Remove(0, 1);
                        direction.east += int.Parse(val);
                        break;

                    case ('W'):
                        val = item.Remove(0, 1);
                        direction.west += int.Parse(val);
                        break;

                    case ('L'):
                        val = item.Remove(0, 1);
                        direction.directionDegrees = -(int.Parse(val));
                        break;

                    case ('R'):
                        val = item.Remove(0, 1);
                        direction.directionDegrees =int.Parse(val);
                        break;
                    case ('F'):
                        switch(direction.Direction)
                        {
                            case ("North"):
                                val = item.Remove(0, 1);
                                direction.north += int.Parse(val);
                                break;
                            case ("East"):
                                val = item.Remove(0, 1);
                                direction.east += int.Parse(val);
                                break;
                            case ("South"):
                                val = item.Remove(0, 1);
                                direction.south += int.Parse(val);
                                break;
                            case ("West"):
                                val = item.Remove(0, 1);
                                direction.west += int.Parse(val);
                                break;
                        }
                        break;
                }
            }

            int distance = Math.Abs(direction.east - direction.west) + Math.Abs(direction.north - direction.south );

            return distance;
        }
    }
}
