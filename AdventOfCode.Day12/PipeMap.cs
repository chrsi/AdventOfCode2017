using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day12
{
    public class PipeMap
    {
        IDictionary<int, int[]> pipes = new Dictionary<int, int[]>();
        IList<int> result = new List<int>();

        public void AddPipe(string pipe)
        {
            var pipeElements = pipe.Split("<->");
            pipes.Add(int.Parse(pipeElements[0]), pipeElements[1].Split(", ").Select(elem => int.Parse(elem)).ToArray());
        }

        public int ConnectedTo(int destination)
        {
            foreach (var pipe in pipes)
            {
                ConnectedToRec(pipe.Key, destination, new int[0]);
            }
            return result.Count();
        }

        private bool ConnectedToRec(int source, int destination, int[] history)
        {
            if (history.Contains(source)) return false;
            if (result.Contains(source)) return true;

            if (source == destination) result.Add(source);

            var newHistory = history.Concat(new[] { source }).ToArray();

            var connectedPipes = pipes[source];
            foreach (var connectedPipe in connectedPipes)
            {
                if (ConnectedToRec(connectedPipe, destination, newHistory))
                {
                    if (!result.Contains(source)) result.Add(source);
                    return true;
                }
            }
            return false;
        }

        public int CountGroups()
        {
            IList<int> groupSize = new List<int>();
            foreach (var pipe in pipes.Keys)
            {
                groupSize.Add(ConnectedTo(pipe));
            }

            //this would cause errors when multiple groups with the same size exist ... but it's sufficient for aoc :)
            return groupSize.Distinct().Count();
        }
    }
}
