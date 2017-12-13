using AdventOfCode.Day12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day12Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new PipeMap();
            solver.AddPipe("0 <-> 2");
            solver.AddPipe("1 <-> 1");
            solver.AddPipe("2 <-> 0, 3, 4");
            solver.AddPipe("3 <-> 2, 4");
            solver.AddPipe("4 <-> 2, 3, 6");
            solver.AddPipe("5 <-> 6");
            solver.AddPipe("6 <-> 4, 5");

            Assert.AreEqual(6, solver.ConnectedTo(0));
        }

        [TestMethod]
        public void Test2()
        {
            var solver = new DayTwelveSolver();
            Assert.AreEqual(193, solver.SolvePart1("../../../Resources/input-12.txt"));
        }

        [TestMethod]
        public void Test3()
        {
            var solver = new PipeMap();
            solver.AddPipe("0 <-> 2");
            solver.AddPipe("1 <-> 1");
            solver.AddPipe("2 <-> 0, 3, 4");
            solver.AddPipe("3 <-> 2, 4");
            solver.AddPipe("4 <-> 2, 3, 6");
            solver.AddPipe("5 <-> 6");
            solver.AddPipe("6 <-> 4, 5");

            Assert.AreEqual(2, solver.CountGroups());
        }

        [TestMethod]
        public void Test4()
        {
            var solver = new DayTwelveSolver();
            Assert.AreEqual(193, solver.SolvePart2("../../../Resources/input-12.txt"));
        }
    }
}
