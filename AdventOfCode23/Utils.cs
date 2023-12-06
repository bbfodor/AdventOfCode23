using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode23
{
    public static class Utils
    {

        public static string GetFileContents(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException($"File not found at {filePath}");
            return File.ReadAllText(filePath);
        }
    }
}
