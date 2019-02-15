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

    }
}