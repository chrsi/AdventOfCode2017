using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq;

namespace AdventOfCode.Day10
{
    public class DayTenSolver
    {
        private int skipSize = 0;
        private int currIndex = 0;

        public int SolvePart1(string file)
        {
            int[] length;
            int[] arr = new int[256];
            for (int i = 0; i < 255; ++i)
            {
                arr[i] = i;
            }

            using (StreamReader reader = new StreamReader(file))
            {
                length = reader.ReadLine().Split(",").Select(item => int.Parse(item)).ToArray();
            }

            return CalcHash(arr, length);
        }

        public string SolvePart2(string file)
        {
            string length;
            using (StreamReader reader = new StreamReader(file))
            {
                length = reader.ReadLine();
            }
            return CalcHashPart2(length);
        }

        public string CalcHashPart2(string input)
        {
            int[] length = input.Select(ch => (int)ch).ToArray();
            int[] arr = new int[256];
            for (int i = 0; i < 256; ++i)
            {
                arr[i] = i;
            }
            length = length.Concat(new[] { 17, 31, 73, 47, 23 }).ToArray();

            for (int i = 0; i < 64; ++i)
            {
                HashRound(arr, length);
            }

            var densedHash = DenseHash(arr);
            return string.Join("", densedHash.Select(d => d.ToString("X2"))).ToLower();
        }

        private IEnumerable<int> DenseHash(int[] arr)
        {
            return arr.Batch(16).Select(b => b.Aggregate((acc, val) => (acc ^ val)));
        }

        public int CalcHash(int[] arr, int[] lengths)
        {
            HashRound(arr, lengths);
            return arr[0] * arr[1];
        }

        public void HashRound(int[] arr, int[] lengths)
        {

            foreach (var length in lengths)
            {
                var affectedSubArr = GetFromArr(arr, currIndex, length);
                Array.Reverse(affectedSubArr);
                ReplacePart(arr, affectedSubArr, currIndex);

                skipSize++;
                currIndex = (currIndex + length + skipSize - 1) % arr.Length;
            }
        }

        private void ReplacePart(int[] arr, int[] affectedSubArr, int currIndex)
        {
            for (int i = 0; i < affectedSubArr.Length; ++i)
            {
                arr[(currIndex + i) % arr.Length] = affectedSubArr[i];
            }
        }

        private int[] GetFromArr(int[] arr, int currIndex, int length)
        {
            int[] partial = new int[length];
            for (int i = 0; i < length; ++i)
            {
                partial[i] = arr[(currIndex + i) % arr.Length];
            }
            return partial;
        }
    }
}
