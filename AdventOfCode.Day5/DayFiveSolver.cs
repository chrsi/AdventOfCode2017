using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Day5
{
    public class DayFiveSolver
    {
        public int SolvePart1(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                var fields = ReadLabyrinth(reader);
                int i = 0;
                int stepCounter = 0;
                while (i < fields.Length)
                {
                    int stepAhead = fields[i];
                    fields[i] += 1;
                    i = i + stepAhead;
                    stepCounter++;
                }
                return stepCounter;
            }
        }
        public int SolvePart2(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                var fields = ReadLabyrinth(reader);
                int i = 0;
                int stepCounter = 0;
                while (i < fields.Length)
                {
                    int stepAhead = fields[i];
                    if (stepAhead >= 3) fields[i] -= 1;
                    else fields[i] += 1;
                    i = i + stepAhead;
                    stepCounter++;
                }
                return stepCounter;
            }
        }

        private static int[] ReadLabyrinth(StreamReader reader)
        {
            var fields = new List<int>();
            while (!reader.EndOfStream) fields.Add(int.Parse(reader.ReadLine()));
            return fields.ToArray();
        }
    }
}
