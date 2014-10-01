using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFCG.ReverseWords
{
    public class WordReverser
    {
        public string ReverseWords(string text)
        {

            //string[] wordList = text.Split(' ');
            //wordList.Reverse();

            //string newSentence = wordList.ToString();

            //return newSentence;

            return text;
        }
    }

    [TestFixture]
    public class WordsReverserTests
    {
        [TestCase("hej", "hej")]
        public void ReverseOrderOfWords_WithOneWord_ReturnTheReversedOrder(string originalOrder, string expected)
        {
            ArrangeActAssert(originalOrder, expected);
        }

        //[TestCase("hej jag", "jag hej")]
        //public void ReverseOrderOfWords_WithTwoWords_ReturnTheReversedOrder(string originalOrder, string expected)
        //{
        //    ArrangeActAssert(originalOrder, expected);
        //}
        

        private static void ArrangeActAssert(string originalOrder, string expected)
        {
            var sentence = new WordReverser();

            var result = sentence.ReverseWords(originalOrder);

            Assert.AreEqual(expected, result);
        }
    }
}
