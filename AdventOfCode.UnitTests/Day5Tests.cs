using AdventOfCode.Day5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day5Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new DayFiveSolver();
            Assert.AreEqual(318883, solver.SolvePart1("../../../Resources/input-5.txt"));
        }

        [TestMethod]
        public void Test2()
        {
            var solver = new DayFiveSolver();
            Assert.AreEqual(23948711, solver.SolvePart2("../../../Resources/input-5.txt"));
        }
    }
}
