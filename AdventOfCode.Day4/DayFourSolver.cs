using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class DayFourSolver
    {
        public int SolvePart1(string file)
        {
            IList<string> passwords = new List<string>();
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    passwords.Add(reader.ReadLine());
                }
            }

            var validator = new PasswordValidator();
            return passwords.Where(password => validator.Validate(password)).Count();
        }

        public int SolvePart2(string file)
        {
            IList<string> passwords = new List<string>();
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    passwords.Add(reader.ReadLine());
                }
            }

            var validator = new PasswordValidator();
            return passwords.Where(password => validator.ValidateWithAnagrams(password)).Count();
        }
    }
}
