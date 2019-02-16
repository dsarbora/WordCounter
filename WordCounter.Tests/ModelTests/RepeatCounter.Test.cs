using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void RepeatCounter_StringsCanBeSet_String()
        {
            string sentence = "You can't do that.";
            string word = "Do";
            RepeatCounter testCounter = new RepeatCounter(sentence, word);
            string sentenceLower=sentence.ToLower();
            Assert.AreEqual (sentenceLower, testCounter.GetSentence());
        }
        [TestMethod]
        public void IsMatch_CanFindMatch_Bool()
        {
            string sentence = "Yes I can";
            string word = "can";
            RepeatCounter testCounter = new RepeatCounter(sentence, word);
            string comparison = testCounter.GetSentenceArray()[2];
            Assert.AreEqual(true, testCounter.IsMatch(comparison, word));
        }
        [TestMethod]
        public void CheckArray_FindsAllMatches_Int()
        {
            string sentence = "Brown bears with brown bags.";
            string word = "brown";
            RepeatCounter testCounter=new RepeatCounter(sentence, word);
            int matches=testCounter.CheckArray(testCounter.GetSentenceArray());
            Assert.AreEqual (2, matches);
        }
        [TestMethod]
        public void CheckArray_FindsOnlyMatches_()
        {
            string sentence = "My friends are coming over";
            string word = "friend";
            RepeatCounter testCounter=new RepeatCounter(sentence, word);
            int matches=testCounter.CheckArray(testCounter.GetSentenceArray());
            Assert.AreEqual (0, matches);
        }
        [TestMethod]
        public void CheckArray_MatchesPunctuatedWords_Int()
        {
            string sentence = "Blue: blue, blue! Blue? Blue.";
            string word = "blue";
            RepeatCounter testCounter=new RepeatCounter(sentence,word);
            int matches=testCounter.CheckArray(testCounter.GetSentenceArray());
            Assert.AreEqual (5, matches);
        }
    }
}