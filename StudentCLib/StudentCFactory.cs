using System;
using System.Collections.Generic;
using System.Text;
using StudentCLib.PunctuationMarkCounter;
using PunctuationCounter = StudentCLib.PunctuationMarkCounter.PunctuationMarkCounter; 

namespace StudentCLib
{
    public static class StudentCFactory
    {
        public static IPunctuationMarkCounter PunctuationMarkCounter()
        {
            return new PunctuationCounter();
        }
    }
}
