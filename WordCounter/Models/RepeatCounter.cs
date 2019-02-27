using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private static List<RepeatCounter> Instances=new List<RepeatCounter>();
        private int Id;
        private static int CurrentId=-1;
        private string Sentence;
        private string Word;
        private int Matches = 0;

        public RepeatCounter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
            Instances.Add(this);
            Id = CurrentId+1;
            RepeatCounter.CurrentId+=1;
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
            string sentence = Sentence.ToLower();
            string[] sentenceArray = sentence.Split(new char[]{' ',',','.',':','!','"','?'});
            return sentenceArray;
        }

        public int CheckArray(string[] sentArr)
        {
            string targetWord = Word.ToLower();
            foreach(string word in sentArr)
            {
                if (this.IsMatch(word, targetWord))
                {
                    Matches++;
                }
            }
            return Matches;
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

        public int GetMatches()
        {
            return Matches;
        }
        
        public static RepeatCounter Find()
        {
            return Instances[CurrentId];
        }
    }
}