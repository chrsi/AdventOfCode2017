using AdventOfCode.Day8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day9Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(1, solver.CountGroups("{}"));
        }
        [TestMethod]
        public void Test2()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(6, solver.CountGroups("{{{}}}"));
        }
        [TestMethod]
        public void Test3()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(5, solver.CountGroups("{{},{}}"));
        }
        [TestMethod]
        public void Test4()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(16, solver.CountGroups("{{{},{},{{}}}}"));
        }
        [TestMethod]
        public void Test5()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(1, solver.CountGroups("{<a>,<a>,<a>,<a>}"));
        }
        [TestMethod]
        public void Test6()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(9, solver.CountGroups("{{<ab>},{<ab>},{<ab>},{<ab>}}"));
        }
        [TestMethod]
        public void Test7()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(9, solver.CountGroups("{{<!!>},{<!!>},{<!!>},{<!!>}}"));
        }
        [TestMethod]
        public void Test8()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(3, solver.CountGroups("{{<a!>},{<a!>},{<a!>},{<ab>}}"));
        }
        [TestMethod]
        public void Test9()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(16021, solver.SolvePart1("../../../Resources/input-9.txt"));
        }

        [TestMethod]
        public void Test10()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(0, solver.CountRemovedChars("<>"));
        }
        [TestMethod]
        public void Test11()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(17, solver.CountRemovedChars("<random characters>"));
        }
        [TestMethod]
        public void Test12()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(3, solver.CountRemovedChars("<<<<>"));
        }
        [TestMethod]
        public void Test13()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(2, solver.CountRemovedChars("<{!>}>"));
        }
        [TestMethod]
        public void Test14()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(0, solver.CountRemovedChars("<!!>"));
        }
        [TestMethod]
        public void Test15()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(0, solver.CountRemovedChars("<!!!>>"));
        }
        [TestMethod]
        public void Test16()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(10, solver.CountRemovedChars("<{o\"i!a,<{i<a>"));
        }
        [TestMethod]
        public void Test17()
        {
            var solver = new DayNineSolver();
            Assert.AreEqual(7685, solver.SolvePart2("../../../Resources/input-9.txt"));
        }

    }
}
