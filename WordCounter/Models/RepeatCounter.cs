using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string Sentence;
        private string Word;
        private int WordMatchCounter = 0;

        public RepeatCounter(string sentence, string word)
        {
            Sentence = sentence.ToLower();
            Word = word.ToLower();
        }
        public string GetSentence()
        {
            return Sentence;
        }
        public string GetWord()
        {
            return Word;
        }

        public string[] GetSentenceArray()
        {
            string[] sentenceArray = Sentence.Split(new char[]{' ',',','.',':','!','"','?'});
            return sentenceArray;
        }

        public int CheckArray(string[] sentArr)
        {
            foreach(string word in sentArr)
            {
                if (this.IsMatch(word, Word))
                {
                    WordMatchCounter++;
                }
            }
                
            return WordMatchCounter;
        }

        public bool IsMatch(string word, string word2)
        {
            if(word == word2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ShowMatches(int matches)
        {
            if(matches==0)
            {
                Console.WriteLine("Match not found.");
            }
            else if(matches==1)
            {
                Console.WriteLine("Found 1 match for "+Word+".");
            }
            else
            {
                Console.WriteLine("Found "+matches+" matches for "+Word+".");
            }
        }
    }
}