using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class Utility
    {

        public static Dictionary<char, int> CountLettersOriginal(string input)
        {
            Dictionary<char, int> toBeReturned = new Dictionary<char, int>();

            var mutatedInput = Regex.Replace(input.ToLower(), @"[^0-9a-zA-Z]+", "");

            foreach (char c in mutatedInput)
            {
                if (toBeReturned.ContainsKey(c))
                    toBeReturned[c]++;
                else
                    toBeReturned.Add(c, 1);
            }

            return toBeReturned;
        }

        public static Dictionary<char, int> CountLettersLinq(string input)
        {
            var mutatedInput = Regex.Replace(input.ToLower(), @"[^0-9a-zA-Z]+", "");

            var query = mutatedInput
                .GroupBy(c => c)
                .Select(c => new { Char = c.Key, Count = c.Count() });

            var toBeReturned = query.ToDictionary(q => q.Char, q => q.Count);

            return toBeReturned;
        }

        public static string ReverseStringOriginal(string input)
        {
            List<char> reverseMe = new List<char>(input.ToCharArray());
            reverseMe.Reverse();

            string toBeReturn = new string(reverseMe.ToArray());

            return toBeReturn;
        }

        public static string ReverseStringLinqSolution(string input)
        {
            return new string(input.Reverse().ToArray());
        }

        public static string ReverseWordsOriginal(string input)
        {
            string toBeReturned = string.Empty;

            foreach (string s in input.Split(' '))
            {
                List<char> reverseMe = new List<char>(s.ToCharArray());
                reverseMe.Reverse();

                string reversedString = new String(reverseMe.ToArray()) + " ";
                toBeReturned += reversedString;
            }

            return toBeReturned;
        }

        public static string ReverseWordsLinqSolution(string input)
        {
            StringBuilder returnMe = new StringBuilder();

            var reverseMe = input
                .Split(' ');

            reverseMe
                .ToList()
                .ForEach(s => returnMe.Append(new string(s.Reverse().ToArray()) + " "));

            return returnMe.ToString();
        }
    }
}
