using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode23
{
    public class Day1 : ISolution<int, int>
    {

        private string Input {  get; set; }
        private IEnumerable<string> ParsedInput { get; set; }

        public Day1(string filePath)
        {
            Input = Utils.GetFileContents(filePath);
            ParsedInput = Input.Split('\n');
        }

        public int GetSolution1()
        {
            IEnumerable<int> results = new List<int>();

            foreach (string line in ParsedInput)
            {
                char firstValue = default;
                char lastValue = default;

                foreach (char character in line)
                {
                    if (!char.IsDigit(character)) continue;
                    if (firstValue == default(char)) firstValue = character;
                    lastValue = character;
                }

                results = results.Append(int.Parse($"{firstValue}{lastValue}"));
            }

            return results.Sum();
        }

        public int GetSolution2()
        {
            throw new NotImplementedException();
        }
    }
}
