using AdventOfCode.Interfaces;
using System;

namespace AdventOfCode.Day1
{
    public class DayOneSolver : ISolver<double>
    {
        public double Solve(string number)
        {
            double result = 0;
            double lastNumber = ConvertCharToNumber(number[number.Length-1]);
            for(int i = 0; i < number.Length; ++i)
            {
                var currentNumber = ConvertCharToNumber(number[i]);
                if (lastNumber == currentNumber)
                {
                    result += currentNumber;
                }
                lastNumber = currentNumber;
            }
            return result;
        }

        private double ConvertCharToNumber(char numberChar)
        {
            return Char.GetNumericValue(numberChar);
        }
    }
}
