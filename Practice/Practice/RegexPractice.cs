using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    internal static class RegexPractice
    {
        public static bool CheckTextWithRegex(this string text)
        {
            return Regex.IsMatch(text, @"\d");
        }

        public static bool CheckTextWithRegexDynamic(this string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }
    }
}
