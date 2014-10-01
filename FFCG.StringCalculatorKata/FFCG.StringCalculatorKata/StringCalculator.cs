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
            return Convert.ToInt32(numbers);
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

        private static void ArrangeActAssert(string numbers, int expected)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}
