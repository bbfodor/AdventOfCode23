using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode23.lib
{
    public class SolutionExecutor
    {

        public SolutionExecutor() { }

        public void ExecuteAllSolutions()
        {
            for (int i = 1; i <= 14; i++)
            {
                ExecuteSolutionForDay(i);
            }
        }

        public void ExecuteSolutionsForSelectDays(int[] days)
        {
            foreach (int day in days)
            {
                ExecuteSolutionForDay(day);
            }
        }

        public void ExecuteSolutionForDay(int dayNum)
        {
            Console.WriteLine($"Day {dayNum}");
            Console.WriteLine("==========");

            ISolution solution;
            try
            {
                solution = new SolutionFactory().CreateSolutionForDay(dayNum);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Not implemented yet!\n");
                return;
            }

            object solution1 = solution.GetSolution1();
            Console.WriteLine($"Solution 1: {solution1}");

            object solution2 = solution.GetSolution2();
            Console.WriteLine($"Solution 2: {solution2}\n");
        }
    }
}
