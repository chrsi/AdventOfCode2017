using AdventOfCode.Day13;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day13Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new DayThirteenSolver();
            Assert.AreEqual(24, solver.SolvePart1("../../../Resources/input-13-Test1.txt"));
        }

        [TestMethod]
        public void Test2()
        {
            var solver = new DayThirteenSolver();
            Assert.AreEqual(788, solver.SolvePart1("../../../Resources/input-13.txt"));
        }

        [TestMethod]
        public void Test3()
        {
            var solver = new DayThirteenSolver();
            Assert.AreEqual(10, solver.SolvePart2("../../../Resources/input-13-Test1.txt"));
        }

        [TestMethod]
        public void Test4()
        {
            var solver = new DayThirteenSolver();
            Assert.AreEqual(3905748, solver.SolvePart2("../../../Resources/input-13.txt"));
        }
    }
}
