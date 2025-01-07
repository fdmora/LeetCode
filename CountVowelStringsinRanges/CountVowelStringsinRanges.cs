public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {     
        int n = words.Length;
        int m = queries.Length;
        int[] ans = new int[m];
        // Create a prefix sum array to store the count of vowel strings for each prefix of words
        int[] prefixSum = new int[n + 1];
        for (int i = 0; i < n; i++) {
            if (IsVowelString(words[i])) {
                prefixSum[i + 1] = prefixSum[i] + 1;
            } else {
                prefixSum[i + 1] = prefixSum[i];
            }
        }
        // Iterate through the queries and calculate the answer for each query
        for (int i = 0; i < m; i++) {
            int l = queries[i][0];
            int r = queries[i][1];
            ans[i] = prefixSum[r + 1] - prefixSum[l];
        }
        return ans;
    }
    // Helper function to check if a string is a vowel string
    private bool IsVowelString(string word) {
        if (word.Length == 0) {
            return false;
        }
        if (!IsVowel(word[0]) || !IsVowel(word[word.Length - 1])) {
            return false;
        }
        return true;
    }

    // Helper function to check if a character is a vowel
    private bool IsVowel(char c) {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}