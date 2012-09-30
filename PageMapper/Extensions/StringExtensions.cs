using System;
using System.Collections.Generic;
using System.Linq;

namespace PageMapper.Extensions
{
    public static class StringExtensions
    {
        public static string Sanatize(this string text)
        {
            var tokens = text.ToList("_");
            return tokens.LastOrDefault();
        }

        public static List<string> ToList(this string text, string separator)
        {
            return text.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}