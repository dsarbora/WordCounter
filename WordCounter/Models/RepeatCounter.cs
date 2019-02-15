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
            Sentence = sentence;
            Word = " " + word + " ";
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
                CharacterMatchCounter = 0;
                if(arrayBeingSearched[i]==wordToSearchFor[0])
                {
                    
                    for(int j = 0; j<wordToSearchFor.Length; ++j)
                    {
                        if( i<arrayBeingSearched.Length&&wordToSearchFor[j]==arrayBeingSearched[i])
                        {
                            ++CharacterMatchCounter;
                            ++i;
                            if (CharacterMatchCounter==wordToSearchFor.Length)
                            {
                                ++WordMatchCounter;
                                Console.WriteLine("Match number " +WordMatchCounter);
                            }
                        }
                        
                    }

                }
                else if((i==0 && wordToSearchFor[1]==arrayBeingSearched[i]) || AcceptableCharacters.Contains(arrayBeingSearched[i]))
                {
                    ++CharacterMatchCounter;
                    for(int j=1; j<wordToSearchFor.Length; ++j)
                    {
                        if(i<=arrayBeingSearched.Length&&(wordToSearchFor[j]==arrayBeingSearched[i] || (j==wordToSearchFor.Length-1 && AcceptableCharacters.Contains(arrayBeingSearched[i]))))
                        {
                            ++CharacterMatchCounter;
                            ++i;
                        }
                        if (CharacterMatchCounter==wordToSearchFor.Length)
                        {
                            WordMatchCounter++;
                            Console.WriteLine("Match number " + WordMatchCounter);
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