using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string Sentence;
        private string Word;
        private int CharacterMatchCounter;
        private int WordMatchCounter = 0;

        public RepeatCounter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
        }

        public string GetSentence()
        {
            return Sentence;
        }



        public void SetCharArrays()
        {
            char[] sentenceArray = Sentence.ToCharArray();
            char[] wordArray = Word.ToCharArray();
            this.SearchArray(sentenceArray, wordArray);
        }

        public void SearchArray(char[] arrayBeingSearched, char[] wordToSearchFor)
        {
            for (int i = 0; i<arrayBeingSearched.Length; ++i)
            {
                if(arrayBeingSearched[i]==wordToSearchFor[0])
                {
                    CharacterMatchCounter = 0;
                    for(int j = 0; j<wordToSearchFor.Length; j++)
                    {
                        if(wordToSearchFor[j]==arrayBeingSearched[i])
                        {
                            CharacterMatchCounter++;
                            Console.WriteLine(CharacterMatchCounter);
                        }
                    }

                }
                else
                {
    
                }
            }
        }

    }
}