using AdventOfCode.Day11;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day11Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new HexGrid();
            Assert.AreEqual(3, solver.CalculateSteps("ne,ne,ne"));
        }

        [TestMethod]
        public void Test2()
        {
            var solver = new HexGrid();
            Assert.AreEqual(0, solver.CalculateSteps("ne,ne,sw,sw"));
        }

        [TestMethod]
        public void Test3()
        {
            var solver = new HexGrid();
            Assert.AreEqual(2, solver.CalculateSteps("ne,ne,s,s"));
        }

        [TestMethod]
        public void Test4()
        {
            var solver = new HexGrid();
            Assert.AreEqual(3, solver.CalculateSteps("se,sw,se,sw,sw"));
        }

        [TestMethod]
        public void Test5()
        {
            var solver = new DayElevenSolver();
            Assert.AreEqual(643, solver.SolvePart1("../../../Resources/input-11.txt"));
        }


        [TestMethod]
        public void Test6()
        {
            var solver = new DayElevenSolver();
            Assert.AreEqual(1471, solver.SolvePart2("../../../Resources/input-11.txt"));
        }
    }
}
