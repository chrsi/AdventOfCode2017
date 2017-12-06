using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day6
{
    public class DaySixSolver
    {
        public int SolvePart1(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                var input = reader.ReadLine().Split('\t').Select(field => int.Parse(field));
                MemoryBank memoryBank = new MemoryBank { Content = input.ToArray() };

                IList<MemoryBank> history = new List<MemoryBank>();
                while (!history.Contains(memoryBank))
                {
                    history.Add(memoryBank);
                    memoryBank = memoryBank.Redistribute();
                }
                return history.Count();
            }
        }
    }
}
