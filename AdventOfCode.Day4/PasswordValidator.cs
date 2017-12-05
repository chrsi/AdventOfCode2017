using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class PasswordValidator
    {
        public bool Validate(string password)
        {
            return NoDuplicates(password);
        }

        public bool ValidateWithAnagrams(string password)
        {
            return NoDuplicates(password) &&
                   !ContainsAnagram(password);
        }

        private static bool NoDuplicates(string password)
        {
            var words = password.Split(' ');
            return words.Distinct().Count() == words.Count();
        }

        private static bool ContainsAnagram(string password)
        {
            var words = password.Split(' ');
            foreach (var word in words)
            {
                foreach (var secondWord in words)
                {
                    if (word != secondWord)
                    {
                        var result = IsAnagram(word, secondWord);
                        if (result) return true;
                    }
                }
            }
            return false;
        }

        private static bool IsAnagram(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
            {
                return false;
            }

            var firstCharMapping = CountChars(firstWord);
            var secondCharMapping = CountChars(secondWord);

            foreach (var chr in firstCharMapping.Keys)
            {
                if (!secondCharMapping.ContainsKey(chr)) return false;
                if (firstCharMapping[chr] != secondCharMapping[chr]) return false;
            }

            return true;
        }

        private static IDictionary<char, int> CountChars(string word)
        {
            var frequency = new Dictionary<char, int>();

            foreach (var chr in word)
            {
                if (!frequency.ContainsKey(chr))
                {
                    frequency.Add(chr, 1);
                }
                else
                {
                    frequency[chr] += 1;
                }
            }
            return frequency;
        }
    }
}