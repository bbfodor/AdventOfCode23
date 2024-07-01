using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode23.utils;

namespace AdventOfCode23.logic
{
    public class Day1 : ISolution
    {

        private string Input { get; set; }
        private IEnumerable<string> ParsedInput { get; set; }

        public Day1(string filePath)
        {
            Input = Utils.GetFileContents(filePath);
            ParsedInput = Input.Split('\n');
        }

        /// <summary>
        /// The input is a newline separated list of strings, each consisting of letters and numbers.
        /// </summary>
        /// <returns>A sum of two-digit numbers formed on each line, by combining the first and last digit respectively.</returns>
        public object GetSolution1()
        {
            IEnumerable<int> results = [];

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

        /// <summary>
        /// The input is a newline separated list of strings, each consisting of letters and numbers.
        /// </summary>
        /// <returns>A sum of two-digit numbers formed on each line, by combining the first and last digit respectively.</returns>
        /// <remarks>Some of the digits are spelled out with letters.</remarks>
        public object GetSolution2()
        {
            IEnumerable<int> results = [];
            string[] strNums = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

            foreach (string line in ParsedInput)
            {
                char firstValue = default;
                char lastValue = default;

                for (int i = 0; i < line.Length; i++)
                {
                    char chr = line[i];

                    if (char.IsDigit(chr))
                    {
                        if (firstValue == default(char)) firstValue = chr;
                        lastValue = chr;
                        continue;
                    }

                    for (int j = 0; j < strNums.Length; j++)
                    {
                        string numStr = strNums[j];
                        bool match = false;

                        for (int k = 0; k < numStr.Length; k++)
                        {
                            if (line[i + k] != numStr[k]) break;
                            if (k == numStr.Length - 1) match = true;
                        }
                        if (!match) continue;

                        char matchedNumChr = Convert.ToChar((j + 1).ToString());
                        if (firstValue == default(char)) firstValue = matchedNumChr;
                        lastValue = matchedNumChr;
                    }
                }

                results = results.Append(int.Parse($"{firstValue}{lastValue}"));
            }

            return results.Sum();
        }
    }
}
