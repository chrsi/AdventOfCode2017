using System.IO;

namespace AdventOfCode.Day12
{
    public class DayTwelveSolver
    {
        public int SolvePart1(string file)
        {
            string input;
            PipeMap pipeMap = new PipeMap();

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    pipeMap.AddPipe(input);
                }
            }
            return pipeMap.ConnectedTo(0);
        }

        public int SolvePart2(string file)
        {
            string input;
            PipeMap pipeMap = new PipeMap();

            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    input = reader.ReadLine();
                    pipeMap.AddPipe(input);
                }
            }
            return pipeMap.CountGroups();
        }
    }
}
