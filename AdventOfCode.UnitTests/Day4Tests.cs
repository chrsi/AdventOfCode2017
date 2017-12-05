using AdventOfCode.Day4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.UnitTests
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        public void Test1()
        {
            var validator = new PasswordValidator();
            Assert.IsTrue(validator.Validate("aa bb cc dd ee"));
        }

        [TestMethod]
        public void Test2()
        {
            var validator = new PasswordValidator();
            Assert.IsFalse(validator.Validate("aa bb cc dd aa"));
        }

        [TestMethod]
        public void Test3()
        {
            var validator = new PasswordValidator();
            Assert.IsTrue(validator.Validate("aa bb cc dd aaa"));
        }

        [TestMethod]
        public void Test4()
        {
            var solver = new DayFourSolver();
            Assert.AreEqual(337, solver.Solve("../../../Resources/input-4-1.txt"));
        }

    }
}
