using AdventOfCode.Day10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day10Tests
    {
        [TestMethod]
        public void Test1()
        {
            var solver = new DayTenSolver();
            int[] arr = { 0, 1, 2, 3, 4 };
            int[] lengthes = { 3, 4, 1, 5 };

            Assert.AreEqual(12, solver.CalcHash(arr, lengthes));
        }

        [TestMethod]
        public void Test2()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual(4480, solver.SolvePart1("../../../Resources/input-10.txt"));
        }

        [TestMethod]
        public void Test3()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual("a2582a3a0e66e6e86e3812dcb672a272", solver.CalcHashPart2(""));
        }

        [TestMethod]
        public void Test4()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual("33efeb34ea91902bb2f59c9920caa6cd", solver.CalcHashPart2("AoC 2017"));
        }
        [TestMethod]
        public void Test5()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual("3efbe78a8d82f29979031a4aa0b16a9d", solver.CalcHashPart2("1,2,3"));
        }
        [TestMethod]
        public void Test6()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual("63960835bcdc130f0b66d7ff4f6a5a8e", solver.CalcHashPart2("1,2,4"));
        }
        
        [TestMethod]
        public void Test7()
        {
            var solver = new DayTenSolver();
            Assert.AreEqual("c500ffe015c83b60fad2e4b7d59dabc4", solver.SolvePart2("../../../Resources/input-10.txt"));
        }
    }
}
