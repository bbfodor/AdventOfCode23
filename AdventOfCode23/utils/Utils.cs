using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace AdventOfCode23.utils
{
    public static class Utils
    {

        public static string GetFileContents(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException($"File not found at '{filePath}'!");
            return File.ReadAllText(filePath);
        }

        public static TEnum? GetEnumFromStr<TEnum>(string str) where TEnum : struct
        {
            string fmtStr = StripTags(str.Replace(" ", ""));
            return Enum.TryParse(fmtStr, out TEnum enumVal) ? enumVal : null;
        }

        public static string StripTags(string input) => Regexes.StripTags().Replace(input, "");

        public static int GetIntFromStr(string str, Func<IEnumerable<int>, int>? processor = null)
        {
            IEnumerable<int> res = [];
            processor ??= res => int.Parse(string.Concat(res));

            foreach (char chr in str)
            {
                if (char.IsDigit(chr))
                {
                    res = res.Append(int.Parse(chr.ToString()));
                }
            }

            return processor(res);
        }

        public static IEnumerable<TOut> TransformEnumerable<TIn, TOut>(IEnumerable<TIn> transformant, Func<TIn, TOut> transformer) =>
            transformant.Select(elem => transformer(elem));
    }
}
