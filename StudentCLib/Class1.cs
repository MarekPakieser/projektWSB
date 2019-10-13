using System;
using System.Linq;

namespace StudentCLib
{
    public interface IPunctuationMarkCounter
    {
        int CountPunctuationMarks(string input);
    }

    internal class PunctuationMarkCounter : IPunctuationMarkCounter
    {
        public int CountPunctuationMarks(string input)
        {
            return input.Where(char.IsPunctuation).Count();
        }
    }
}
