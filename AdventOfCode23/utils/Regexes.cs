using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode23.utils
{
    public static partial class Regexes
    {

        [GeneratedRegex(@"\[.*?\]")]
        public static partial Regex StripTags();
    }
}
