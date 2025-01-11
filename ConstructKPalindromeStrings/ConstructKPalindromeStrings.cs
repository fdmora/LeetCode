public class Solution {
    public bool CanConstruct(string s, int k) {
        // Dictionary to store the frequency of characters
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        
        // Count the frequency of each character in the string
        foreach (var c in s) {
            if (frequency.ContainsKey(c)) {
                frequency[c]++;
            } else {
                frequency[c] = 1;
            }
        }

        // Count the number of characters with odd frequencies
        int oddCount = 0;
        foreach (var count in frequency.Values) {
            if (count % 2 != 0) {
                oddCount++;
            }
        }

        // To form k palindromes, we need at least oddCount <= k
        return oddCount <= k;
    }
}