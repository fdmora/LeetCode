public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
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
