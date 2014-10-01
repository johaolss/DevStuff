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
            //if numbers is int
                //return Convert.ToInt32(numbers);



            //int value;
            //if (int.TryParse(numbers, out value))
            //    return Convert.ToInt32(numbers);


            string[] stringarray = numbers.Split(',');
            if (stringarray.Length==1)
            {
                return int.Parse(stringarray[0]);
            }
            return int.Parse(stringarray[0]) + int.Parse(stringarray[1]);

            //return 1234;

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

        [TestCase("", 0)]
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

        private static void ArrangeActAssert(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}