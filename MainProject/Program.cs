using System;
using StudentCLib;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "as,dasdawda";
            var punctuationCounter = StudentCFactory.PunctuationMarkCounter();

            int punctuationMarks = punctuationCounter.CountPunctuationMarks(input);
            Console.WriteLine(punctuationMarks.ToString());
        }
    }
}
