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
            Assert.AreEqual (sentence, testCounter.GetSentence());
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

    }
}