using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day2
{
    public class DayTwoSolver
    {
        public double Solve(string input)
        {
            var rows = TransformInput(input);
            double result = 0;
            foreach (var col in rows)
            {
                double min = col[0], max = col[0];
                for (int i = 0; i < col.Count; ++i)
                {
                    if (col[i] < min) min = col[i];
                    if (col[i] > max) max = col[i];
                }
                result += (max - min);
            }
            return result;
        }

        public double SolvePart2(string input)
        {
            var rows = TransformInput(input);
            double result = 0;
            foreach (var cols in rows)
            {
                for (int i = 0; i < cols.Count; ++i)
                {
                    for (int j = 0; j < cols.Count; ++j)
                    {
                        if (i == j) continue;
                        if (cols[i] % cols[j] == 0) result += cols[i] / cols[j];
                    }
                }
            }
            return result;
        }

        private static IEnumerable<List<double>> TransformInput(string input)
        {
            return input.Split("\r\n").Select(row => row.Trim().Split(new char[] { '\t', ' ' }).Select(ch => double.Parse(ch)).ToList());
        }
    }
}
