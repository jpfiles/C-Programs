using System;

namespace AbecedarianCheck
{
    public class Program
    {
        // Iterative approach
        public static bool IsAbecedarianIterative(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] > word[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Recursive approach
        public static bool IsAbecedarianRecursive(string word)
        {
            // Base case: if the word has one or no characters, it's abecedarian
            if (word.Length <= 1)
            {
                return true;
            }

            // Check the first two characters
            if (word[0] > word[1])
            {
                return false;
            }

            // Recursively check the rest of the word
            return IsAbecedarianRecursive(word.Substring(1));
        }

        public static void Main(string[] args)
        {
            string[] testWords = { "abdest", "agnosy", "biopsy", "deux", "dimpsy", "apple" };

            Console.WriteLine("Testing Iterative Approach:");
            foreach (var word in testWords)
            {
                Console.WriteLine($"{word}: {IsAbecedarianIterative(word)}");
            }

            Console.WriteLine("\nTesting Recursive Approach:");
            foreach (var word in testWords)
            {
                Console.WriteLine($"{word}: {IsAbecedarianRecursive(word)}");
            }
        }
    }
}
