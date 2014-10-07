using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFCG.fizzbuzzkata
{
    public class FizzBuzzKata : IFizzBuzzKata
    {
        public string Answer(int i)
        {
            // throw new NotImplementedException();

            if (i %3 == 0 && i %15 != 0)
            {
                return "fizz";
            }

            if (i % 5 == 0 && i % 15 != 0)
            {
                return "buzz";
            }

            if (i % 15 == 0)
            {
                return "fizzbuzz";
            }

            return i.ToString();
        }
    }

    public interface IFizzBuzzKata
    {
        /// <summary>
        /// Give an answer to the current game
        /// </summary>
        /// <param name="number">current number in the game sequence</param>
        /// <returns>appropriate answer to the current number</returns>
        string Answer(int number);
    }

    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        [TestCase(8, "8")]
        [TestCase(11, "11")]
        [TestCase(13, "13")]
        [TestCase(14, "14")]
        public void Test_WithNumberNotDivisibleBy3or5_ReturnThatNumber(int numbers, string expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase(3, "fizz")]
        [TestCase(6, "fizz")]
        [TestCase(9, "fizz")]
        [TestCase(12, "fizz")]
        public void Test_WithNumberDivisibleBy3_ReturnFizz(int numbers, string expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase(5, "buzz")]
        [TestCase(10, "buzz")]
        public void Test_WithNumberDivisibleBy5_ReturnBuzz(int numbers, string expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase(15, "fizzbuzz")]
        public void Test_WithNumberDivisibleBy15_ReturnFizzBuzz(int numbers, string expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        private static void ArrangeActAssert(int numbers, string expected)
        {
            var fizzbuzzer = new FizzBuzzKata();

            var result = fizzbuzzer.Answer(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
