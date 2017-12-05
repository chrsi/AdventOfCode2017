using System.Linq;

namespace AdventOfCode.Day4
{
    public class PasswordValidator
    {
        public bool Validate(string password)
        {
            return NoDuplicates(password);
        }

        private static bool NoDuplicates(string password)
        {
            var words = password.Split(' ');
            return words.Distinct().Count() == words.Count();
        }
    }
}