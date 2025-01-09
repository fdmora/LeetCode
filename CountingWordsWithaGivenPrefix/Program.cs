using System;

class Program
{
    static void Main()
    {
        // Example input
        string[] words1 = { "pay", "attention", "practice", "attend" };
        string pref1 = "at";
        Console.WriteLine(CountWordsWithPrefix(words1, pref1)); // Output: 2

        string[] words2 = { "leetcode", "win", "loops", "success" };
        string pref2 = "code";
        Console.WriteLine(CountWordsWithPrefix(words2, pref2)); // Output: 0
    }

    static int CountWordsWithPrefix(string[] words, string pref)
    {
        int count = 0;

        foreach (string word in words)
        {
            if (word.StartsWith(pref))
            {
                count++;
            }
        }

        return count;
    }
}