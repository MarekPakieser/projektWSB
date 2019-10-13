using StudentCLib.PunctuationMarkCounter;
using StudentCLib.SentencesCounter;
using PunctuationCounter = StudentCLib.PunctuationMarkCounter.PunctuationMarkCounter; 

namespace StudentCLib
{
    public static class StudentCFactory
    {
        public static IPunctuationMarkCounter PunctuationMarkCounter()
        {
            return new PunctuationCounter();
        }

        public static ISentencesCounter SentencesCounter()
        {
            return new SentencesCounter.SentencesCounter();
        }
    }
}
