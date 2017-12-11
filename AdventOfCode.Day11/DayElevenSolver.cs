using System.IO;

namespace AdventOfCode.Day11
{
    public class DayElevenSolver
    {
        public int SolvePart1(string file)
        {
            string input;
            using (StreamReader reader = new StreamReader(file))
            {
                input = reader.ReadLine();
            }

            HexGrid grid = new HexGrid();
            return grid.CalculateSteps(input);
        }

        public int SolvePart2(string file)
        {
            string input;
            using (StreamReader reader = new StreamReader(file))
            {
                input = reader.ReadLine();
            }

            var steps = input.Split(',');
            int maxSteps = 0;
            for (int i = 1; i <= steps.Length; ++i)
            {
                HexGrid grid = new HexGrid();
                var stepCount = grid.CalculateSteps(string.Join(',', input.Split(','), 0, i));
                maxSteps = maxSteps < stepCount ? stepCount : maxSteps;
            }
            return maxSteps;
        }
    }
}
