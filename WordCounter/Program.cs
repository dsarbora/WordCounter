using System;
using WordCounter.Models;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Give me a sentence");
            string inputString = Console.ReadLine();
            Console.WriteLine("Give me a word to match");
            string inputWord = Console.ReadLine();
            RepeatCounter counter = new RepeatCounter(inputString, inputWord);
            counter.ShowMatches(counter.CheckArray(counter.GetSentenceArray()));

        }
    }
}