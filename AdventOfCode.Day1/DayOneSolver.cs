using System;
using System.Linq;

namespace AdventOfCode.Day1
{
    public class DayOneSolver
    {
        public double Solve(string number, int offset = 1)
        {
            var numbers = number.Select(chr => ConvertCharToNumber(chr)).ToList();

            double result = 0;
            for(int i = 0; i < numbers.Count; ++i)
            {
                var lastNumber = numbers[i];
                var currentNumber = ConvertCharToNumber(number[(i+offset)% numbers.Count]);
                if (lastNumber == currentNumber)
                {
                    result += currentNumber;
                }
            }
            return result;
        }

        private double ConvertCharToNumber(char numberChar)
        {
            return Char.GetNumericValue(numberChar);
        }
    }
}
