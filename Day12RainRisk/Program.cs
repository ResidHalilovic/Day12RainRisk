using System;
using System.Collections.Generic;

namespace Day12RainRisk
{
    class Program
    {
        static void Main(string[] args)
        {
            Direction1 part1 = new Direction1();
            Direction2 part2 = new Direction2();
            List<string> list = new List<string>();
            string line;
            List<string> inputdata = new List<string>();

            list.Add("F10");
            list.Add("N3");
            list.Add("F7");
            list.Add("R90");
            list.Add("F11");

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\DELL\source\repos\Day12RainRisk\Day12RainRisk\inputs\input.txt");

            while ((line = file.ReadLine()) != null)
            {
                inputdata.Add(line);
            }

            int part2ANS = part2.calc(inputdata);
            int part1ANS = part1.calc(inputdata);

            Console.WriteLine($"Part 1:\t{part1ANS}");
            Console.WriteLine($"Part 2:\t{part2ANS}");
        }
    }
}
