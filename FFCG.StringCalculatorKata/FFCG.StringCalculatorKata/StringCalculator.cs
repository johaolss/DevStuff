using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FFCG.StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;

            char newDelimiter = ',';

            if (numbers.StartsWith("//"))
            {
                newDelimiter = numbers[2];
                numbers = numbers.Remove(0, 4);
            }

            numbers = numbers.Replace('\n', newDelimiter);

            string[] stringarray = numbers.Split(newDelimiter);

            int sumOfNumbers = 0;
            foreach (string currentNumber in stringarray)
            {
                sumOfNumbers += int.Parse(currentNumber);
            }

            return sumOfNumbers;

        }
    }
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Add_WithEmptyString_Return0()
        {
            ArrangeActAssert("", 0);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_WithSingleNumber_ReturnThatNumber(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("3,4", 7)]
        [TestCase("33,4", 37)]
        public void Add_TwoNumbers_ReturnSumOfThoseNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("1,2,3,4", 10)]
        public void Add_UnknownAmountOfNumbers_ReturnSumOfThoseNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("1\n2,3,4", 10)]
        public void Add_BackslashNAsDelimiter_ReturnSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("//;\n1;2;3", 6)]
        public void Add_AnyCharAsDelimiter_ReturnSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        private static void ArrangeActAssert(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}