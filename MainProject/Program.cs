using System;
using StudentCLib;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "as,dasdawda.";
            var punctuationCounter = StudentCFactory.PunctuationMarkCounter();
            var sentencesCounter = StudentCFactory.SentencesCounter();

            int punctuationMarks = punctuationCounter.CountPunctuationMarks(input);
            int sentencesCount = sentencesCounter.CountSentences(input);

            Console.WriteLine(punctuationMarks.ToString());
            Console.WriteLine(sentencesCount.ToString());
        }
    }
}
