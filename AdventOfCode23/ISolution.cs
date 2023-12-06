using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode23
{
    public interface ISolution<TSolution1, TSolution2>
    {

        public TSolution1 GetSolution1();

        public TSolution2 GetSolution2();
    }
}
