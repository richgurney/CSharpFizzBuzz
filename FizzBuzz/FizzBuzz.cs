using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public List<string> FizzBuzzList;

        public FizzBuzz(int StartOfRange, int EndOfRange)
        {
            FizzBuzzList = new List<string>();
            FizzBuzzIterator(GenerateRange(StartOfRange, EndOfRange));
        }

        public bool DivisibleBy(int num1, int num2)
        {
            return num1 % num2 == 0;
        }

        public IEnumerable<int> GenerateRange(int StartOfRange, int EndOfRange)
        {
            IEnumerable<int> range = Enumerable.Range(StartOfRange, EndOfRange);

            return range;
        }

        public void FizzBuzzIterator(IEnumerable<int> range)
        {
            foreach (var num in range)
            {
                if (DivisibleBy(num, 15))
                {
                    FizzBuzzList.Add("FizzBuzz");
                }
                else if (DivisibleBy(num, 5))
                {
                    FizzBuzzList.Add("Buzz");
                }
                else if (DivisibleBy(num, 3))
                {
                    FizzBuzzList.Add("Fizz");
                }
                else
                {
                    FizzBuzzList.Add(num.ToString());
                }
            }
        }
    }
}
