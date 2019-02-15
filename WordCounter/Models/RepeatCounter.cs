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
                    for (int j = 0; j<wordToSearchFor.Length; j++)
                    {
                        this.ReturnNumberOfMatches();
                    }
                }
                else if(i==0 && arrayBeingSearched[i]==wordToSearchFor[1])
                {
                    for (int j = 1; j<wordToSearchFor.Length; j++)
                    {
                        CharacterMatchCounted++;
                        if(wordToSearchFor[j]==arrayBeingSearched[i])
                        {
                            ++CharacterMatchCounter;
                            ++i;
                            Console.WriteLine(CharacterMatchCounter);
                            if(CharacterMatchCounter==wordToSearchFor.Length)
                            {
                                WordMatchCounter++;
                                Console.WriteLine(WordMatchCounter);
                            }
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