using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day8
{
    public class DayNineSolver
    {
        public int SolvePart1(string file)
        {
            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                return CountGroups(line);
            }
        }

        public int CountRemovedChars(string line)
        {
            line = Regex.Replace(line, "!.", "");
            var matches = Regex.Matches(line, "<.*?>");

            return matches.Sum(m =>
            {
                return m.Length - 2;
            });

        }

        public int CountGroups(string line)
        {
            line = Regex.Replace(line, "!.", "");
            line = Regex.Replace(line, "<.*?>", "");

            int lvl = 0;
            int cnt = 0;
            foreach (var chr in line)
            {
                if (chr == '{')
                {
                    lvl += 1;
                    cnt += lvl;
                }
                if (chr == '}')
                {
                    lvl -= 1;
                }
            }
            return cnt;
        }

        public int SolvePart2(string file)
        {
            using (var reader = new StreamReader(file))
            {
                var line = reader.ReadLine();
                return CountRemovedChars(line);
            }
        }
    }
}
