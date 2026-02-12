using System;
using System.Collections.Generic;

namespace Medwizrx.Models
{
    public static class GetFirstUniqueChar
    {
        public static char? FirstUniqueChar(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            var charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.TryGetValue(c, out int value))
                    charCount[c] = ++value;
                else
                    charCount[c] = 1;
            }

            foreach (char c in input)
            {
                if (charCount[c] == 1)
                    return c;
            }

            return null;
        }
    }
}
