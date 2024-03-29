﻿using System.Collections.Generic;
using System.Linq;

namespace SingleCalculatedValue1
{
    public static class Count1
    {
        // Return the number of strings in the provided sequence that begin with
        // the provided startString.
        public static int NumberThatStartWith(IEnumerable<string> words, string startString)
        {
            // Uncomment:
            // return words.???();
            return words.Count(word => word.StartsWith(startString));
        }
    }
}