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
            return text;
        }
    }

    [TestFixture]
    public class WordsReverserTests
    {
        [TestCase("hej", "hej")]
        public void ReverseOrderOfWords_ReturnTheReversedOrder(string originalOrder, string expected)
        {
            ArrangeActAssert(originalOrder, expected);
        }
        

        private static void ArrangeActAssert(string originalOrder, string expected)
        {
            var sentence = new WordReverser();

            var result = sentence.ReverseWords(originalOrder);

            Assert.AreEqual(expected, result);
        }
    }
}
