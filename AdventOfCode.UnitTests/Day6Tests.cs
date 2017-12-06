using AdventOfCode.Day6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day6Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new DaySixSolver();
            Assert.AreEqual(11137, solver.SolvePart1("../../../Resources/input-6.txt"));
        }
    }
}
