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

        public static string ReverseStringOriginal(string input)
        {
            List<char> reverseMe = new List<char>(input.ToCharArray());
            reverseMe.Reverse();

            string toBeReturn = new string(reverseMe.ToArray());

            return toBeReturn;
        }

        // Interestingly I had to google this one but no ReverseWordsLinqSolution
        // It's funny how I use both Reverse() and ToArray()
        // In the original solution but add extra steps to complete the task
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
            // Use a builder to return value
            StringBuilder returnMe = new StringBuilder();

            // Split initial string to string[] so we can ForEach
            var reverseMe = input
                .Split(' ');

            // Iterate each string, 
            // Reverse it and convert away from IEnumerable back to a string 
            // Append to string builder
            reverseMe
                .ToList()
                .ForEach(s => returnMe.Append(new string(s.Reverse().ToArray()) + " "));

            return returnMe.ToString();
        }
    }
}
