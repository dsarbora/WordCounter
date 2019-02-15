using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string Sentence;
        private string Word;
        private char[] AcceptableCharacters=
        {'!',',','.','/',';',':','"','%','(',')','?'};
        private int CharacterMatchCounter;
        private int WordMatchCounter = 0;

        public RepeatCounter(string sentence, string word)
        {
            Sentence = " " + sentence + " ";
            Word = " " + word + " ";
        }

        public string GetSentence()
        {
            return Sentence;
        }



        public int SetCharArrays()
        {
            char[] sentenceArray = Sentence.ToCharArray();
            char[] wordArray = Word.ToCharArray();
            this.DisplayMessage(this.SearchArray(sentenceArray, wordArray));   
        }

        public int SearchArray(char[] arrayBeingSearched, char[] wordToSearchFor)
        {
            for (int i = 0; i<arrayBeingSearched.Length; ++i)
            {
                CharacterMatchCounter = 0;
                if(arrayBeingSearched[i]==wordToSearchFor[0]||AcceptableCharacters.Contains(arrayBeingSearched[i]))
                {
                    for(int j = 0; j<wordToSearchFor.Length; ++j)
                    {
                        if( i<arrayBeingSearched.Length&&(AcceptableCharacters.Contains(arrayBeingSearched[i])||wordToSearchFor[j]==arrayBeingSearched[i]))
                        {
                            ++CharacterMatchCounter;
                            ++i;
                            if(j==arrayBeingSearched.Length-1)
                            {
                                i--;
                                Console.WriteLine("subtracted from i");
                            }
                            if (CharacterMatchCounter==wordToSearchFor.Length)
                            {
                                ++WordMatchCounter;
                                 Console.WriteLine(WordMatchCounter);
                            }
                        }    
                    }
                }
            }
            return WordMatchCounter;
        }

        public void DisplayMessage(int matches)
        {
            if(matches == 0)
            {
                Console.WriteLine("I couldn't find a match.");
            }
            else if(matches == 1)
            {
                Console.WriteLine("One item matched.");
            }
            else
            {
                Console.WriteLine("I found you " + matches + " matches.");
            }
        }

    }
}