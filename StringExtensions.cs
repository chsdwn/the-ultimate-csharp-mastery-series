using System;
using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words cannot be lower than zero.");

            if (numberOfWords == 0)
                return String.Empty;

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
                return str;

            return string.Join(' ', words.Take(numberOfWords));
        }
    }
}