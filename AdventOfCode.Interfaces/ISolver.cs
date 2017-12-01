using System;

namespace AdventOfCode.Interfaces
{
    public interface ISolver<T>
    {
        T Solve(string input, int i);
    }
}
