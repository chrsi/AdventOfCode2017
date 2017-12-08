using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day7
{
    public class DaySevenSolver
    {
        private class Node
        {
            public string Value { get; set; }
            public IList<Node> Children { get; set; } = new List<Node>();
            public override string ToString() => Value;
            public override bool Equals(object obj)
            {
                var n = obj as Node;
                return Value.Equals(n.Value);
            }
        }

        public int SolvePart2(string v)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, IEnumerable<string>> repo = new Dictionary<string, IEnumerable<string>>();
        IList<Node> targetRepo = new List<Node>();
        IList<Node> usedNodes = new List<Node>();

        public string SolvePart1(string file)
        {
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(" -> ");
                    if (line.Length > 1)
                        repo.Add(line[0].Split(' ')[0], line[1].Split(", "));
                    else
                        repo.Add(line[0].Split(' ')[0], new List<string>());
                }

                foreach (var nodePair in repo)
                {
                    var node = nodePair.Key;
                    var children = nodePair.Value;

                    var r = ConvertNode(node);
                    if (!usedNodes.Contains(r))
                    {
                        targetRepo.Add(r);
                    }
                }

                return targetRepo.FirstOrDefault().Value;
            }
        }

        private Node ConvertNode(string node)
        {
            var res = usedNodes.FirstOrDefault(n => n.Value.Equals(node));
            if (res == null)
            {
                res = new Node
                {
                    Value = node,
                    Children = repo[node].Select(childNode => ConvertNode(childNode)).ToList()
                };
                foreach (var c in res.Children)
                {
                    usedNodes.Add(c);
                }
            }
            targetRepo.Remove(res);
            return res;
        }
    }
}