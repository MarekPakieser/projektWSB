using System.Linq;

namespace StudentCLib.PunctuationMarkCounter
{
    internal class PunctuationMarkCounter : IPunctuationMarkCounter
    {
        public int CountPunctuationMarks(string input)
        {
            return input.Where(char.IsPunctuation).Count();
        }
    }
}