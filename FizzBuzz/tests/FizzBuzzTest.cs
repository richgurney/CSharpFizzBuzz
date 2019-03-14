using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    [TestFixture()]
    public class FizzBuzzTest
    {
        FizzBuzz fizzbuzz = new FizzBuzz(1, 15);

        [Test()]
        public void TestDivisibleBy()
        {
            Assert.AreEqual(true, fizzbuzz.DivisibleBy(6, 3));
            Assert.AreEqual(false, fizzbuzz.DivisibleBy(5, 3));

        }

        [Test()]
        public void TestFizzBuzzIterator()
        {
            Assert.AreEqual("Fizz", fizzbuzz.FizzBuzzList[2]);
            Assert.AreEqual("Buzz", fizzbuzz.FizzBuzzList[4]);
            Assert.AreEqual("FizzBuzz", fizzbuzz.FizzBuzzList[14]);
        }
    }
}
