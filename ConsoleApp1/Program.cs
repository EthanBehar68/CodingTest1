using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Letter Test");
            Dictionary<char, int> test = Utility.CountLettersOriginal("Hey, this is my first test.");
            Console.WriteLine("Original Solution: ");
            foreach (KeyValuePair<char, int> pair in test)
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);

            test = Utility.CountLettersLinq("Hey, this is my first test.");
            Console.WriteLine("LINQ Solution: ");
            foreach (KeyValuePair<char, int> pair in test)
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);

            Console.WriteLine();

            Console.WriteLine("Reverse String Test");
            Console.WriteLine("Original Solution: " + Utility.ReverseStringOriginal("Hey, this is my first test."));
            Console.WriteLine("LINQ Solution: " + Utility.ReverseStringLinqSolution("Hey, this is my first test."));


            Console.WriteLine();

            Console.WriteLine("Reverse Words Test");
            Console.WriteLine("Original Solution: " + Utility.ReverseWordsOriginal("Hey, this is my first test."));
            Console.WriteLine("LINQ Solution: " + Utility.ReverseWordsLinqSolution("Hey, this is my first test."));

            Console.WriteLine();
        }
    }
}
