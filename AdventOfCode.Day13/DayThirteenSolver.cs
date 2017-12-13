using System.IO;
using System.Linq;

namespace AdventOfCode.Day13
{
    public class DayThirteenSolver
    {
        public int SolvePart1(string file)
        {
            int arrSize;
            using (StreamReader reader = new StreamReader(file))
            {
                string input = null;
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                }
                arrSize = int.Parse(input.Split(": ")[0]);
            }
            int[] arr = new int[arrSize + 1];
            using (StreamReader reader = new StreamReader(file))
            {
                string input = null;
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    var line = input.Split(": ").Select(item => int.Parse(item)).ToArray();
                    arr[line[0]] = line[1];
                }
            }

            int sum = 0;
            for (int i = 0; i <= arrSize; ++i)
            {
                var pos = CalculatePosition(i, arr[i]);
                if (pos == 0) sum += arr[i] * i;
            }
            return sum;
        }

        public int SolvePart2(string file)
        {
            int arrSize;
            using (StreamReader reader = new StreamReader(file))
            {
                string input = null;
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                }
                arrSize = int.Parse(input.Split(": ")[0]);
            }
            int[] arr = new int[arrSize + 1];
            using (StreamReader reader = new StreamReader(file))
            {
                string input = null;
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    var line = input.Split(": ").Select(item => int.Parse(item)).ToArray();
                    arr[line[0]] = line[1];
                }
            }

            int sum = 0;
            int j = 0;
            do
            {
                sum = 0;
                for (int i = j; i <= arrSize + j; ++i)
                {
                    var pos = CalculatePosition(i, arr[i - j]);
                    if (pos == 0) sum += arr[i - j] * i;
                }
                j++;
            } while (sum != 0);
            return j - 1;
        }

        private int CalculatePosition(int idx, int depth)
        {
            if (depth == 0) return -1;
            if (idx / (depth - 1) % 2 == 0)
            {
                //downward
                return idx % (depth - 1);
            }
            else
            {
                //upward
                return depth - (idx % (depth - 1)) - 1;
                // 5, 4 --- 4 - (5%4) - 2 = 1
            }
        }
    }
}
