using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace codekata1
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return int.Parse(input);
        }

        public int Subtract(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return int.Parse(input);
        }
    }

    public class StringCalculatorTest
    {
        private StringCalculator _sut;

        [SetUp]
        public void Setup()
        {
            this._sut = new StringCalculator();    
        }

        [Test]
        [TestCase("",0)]
        [TestCase("1", 1)]
        public void AddNumbersInString_Return_SumOfThoseNumbers(string input, int expected)
        {
            int result = this._sut.Add(input);

            Assert.AreEqual(expected, result);
        }

    }
}
