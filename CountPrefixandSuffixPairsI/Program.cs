using System;

public class Solution {
    public int CountPrefixAndSuffixPairs(string[] words) {
        int count = 0;
        int n = words.Length;

        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (IsPrefixAndSuffix(words[i], words[j])) {
                    count++;
                }
            }
        }

        return count;
    }

    private bool IsPrefixAndSuffix(string str1, string str2) {
        // Check if str1 is a prefix of str2
        if (str2.StartsWith(str1)) {
            // Check if str1 is a suffix of str2
            return str2.EndsWith(str1);
        }
        return false;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        string[] words1 = { "a", "aba", "ababa", "aa" };
        Console.WriteLine(solution.CountPrefixAndSuffixPairs(words1)); // Output: 4
        
        string[] words2 = { "pa", "papa", "ma", "mama" };
        Console.WriteLine(solution.CountPrefixAndSuffixPairs(words2)); // Output: 2
        
        string[] words3 = { "abab", "ab" };
        Console.WriteLine(solution.CountPrefixAndSuffixPairs(words3)); // Output: 0
    }
}