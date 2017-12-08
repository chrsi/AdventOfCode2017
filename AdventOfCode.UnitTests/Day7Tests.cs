using AdventOfCode.Day7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day7Tests
    {
        [TestMethod]
        public void Test7()
        {
            var solver = new DaySevenSolver();
            Assert.AreEqual("bpvhwhh", solver.SolvePart1("../../../Resources/input-7.txt"));
        }

        //[TestMethod]
        public void Test2()
        {
            var solver = new DaySevenSolver();
            Assert.AreEqual(1037, solver.SolvePart2("../../../Resources/input-7.txt"));
        }
    }
}
