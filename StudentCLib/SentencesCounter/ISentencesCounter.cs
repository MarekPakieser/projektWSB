using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentCLib.SentencesCounter
{
    public interface ISentencesCounter
    {
        int CountSentences(string input);
    }

    class SentencesCounter : ISentencesCounter
    {
        public int CountSentences(string input)
        {
            return input.Count(c => c == '.');
        }
    }
}
