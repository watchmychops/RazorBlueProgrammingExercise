using System;
using System.Linq;

namespace Task1Anagram {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello razorblue! Enter two strings to check if they are anagrams.");

            string first = Console.ReadLine();
            string second = Console.ReadLine();

            Console.WriteLine(IsAnagramOf(first, second));
        }

        private static bool IsAnagramOf(string a, string b) {
            var aOrdered = a.OrderBy(c => c);
            var bOrdered = b.OrderBy(c => c);
            return aOrdered.SequenceEqual(bOrdered);
        }

    }
}
