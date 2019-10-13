using System.Linq;

namespace StudentCLib.SentencesCounter
{
    internal class SentencesCounter : ISentencesCounter
    {
        public int CountSentences(string input)
        {
            return input.Count(c => c == '.');
        }
    }
}