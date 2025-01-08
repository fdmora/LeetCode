public class Solution {
    public int CountPalindromicSubsequence(string s) {
        if (s.Length < 3) {
            return 0;
        }
        HashSet<string> palindromes = new HashSet<string>();
        for (int i = 0; i < s.Length - 2; i++) {
            for (int j = i + 1; j < s.Length - 1; j++) {
                for (int k = j + 1; k < s.Length; k++) {
                    if (s[i] == s[k] && s[j] == s[j]) {
                        string palindrome = s[i].ToString() + s[j].ToString() + s[k].ToString();
                        if (!palindromes.Contains(palindrome)) {
                            palindromes.Add(palindrome);
                        }
                    }
                }
            }
        }
        return palindromes.Count;
    }
}