using AdventOfCode23.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode23.lib
{
    public class SolutionFactory
    {

        public SolutionFactory() { }

        public ISolution CreateSolutionForDay(int dayNum)
        {
            return dayNum switch
            {
                1 => new Day1("data/day1.dat"),
                2 => throw new NotImplementedException(),
                3 => throw new NotImplementedException(),
                4 => throw new NotImplementedException(),
                5 => throw new NotImplementedException(),
                6 => throw new NotImplementedException(),
                7 => throw new NotImplementedException(),
                8 => throw new NotImplementedException(),
                9 => throw new NotImplementedException(),
                10 => throw new NotImplementedException(),
                11 => throw new NotImplementedException(),
                12 => throw new NotImplementedException(),
                13 => throw new NotImplementedException(),
                14 => throw new NotImplementedException(),
                _ => throw new ArgumentException("Provided day is invalid (1-14)!"),
            };
        }
    }
}
