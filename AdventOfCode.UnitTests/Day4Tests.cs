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
            Assert.AreEqual(337, solver.SolvePart1("../../../Resources/input-4-1.txt"));
        }

        [TestMethod]
        public void Test5()
        {
            var validator = new PasswordValidator();
            Assert.IsTrue(validator.ValidateWithAnagrams("abcde fghij"));
        }
        [TestMethod]
        public void Test6()
        {
            var validator = new PasswordValidator();
            Assert.IsFalse(validator.ValidateWithAnagrams("abcde xyz ecdab"));
        }
        [TestMethod]
        public void Test7()
        {
            var validator = new PasswordValidator();
            Assert.IsTrue(validator.ValidateWithAnagrams("a ab abc abd abf abj"));
        }
        [TestMethod]
        public void Test8()
        {
            var validator = new PasswordValidator();
            Assert.IsTrue(validator.ValidateWithAnagrams("iiii oiii ooii oooi"));
        }
        [TestMethod]
        public void Test9()
        {
            var validator = new PasswordValidator();
            Assert.IsFalse(validator.ValidateWithAnagrams("oiii ioii iioi iiio"));
        }

        [TestMethod]
        public void Test10()
        {
            var solver = new DayFourSolver();
            Assert.AreEqual(231, solver.SolvePart2("../../../Resources/input-4-1.txt"));
        }

    }
}
